using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nutripuc_E3.Models;

namespace Nutripuc_E3.Controllers
{
    [Route("registros")]
    public class RegistrosDeAlimentacaoController : Controller
    {
        private readonly AppDbContext _context;

        public RegistrosDeAlimentacaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RegistrosDeAlimentacao
        [HttpGet("alimentacao")]
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.RegistrosDeAlimentacao.Include(a => a.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: RegistrosDeAlimentacao/Details/5
        [HttpGet("alimentacao/details")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.RegistrosDeAlimentacao == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.RegistrosDeAlimentacao
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alimentacao == null)
            {
                return NotFound();
            }

            return View(alimentacao);
        }

        // GET: RegistrosDeAlimentacao/Create
        [HttpGet("alimentacao/create")]
        public IActionResult Create()
        {
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: RegistrosDeAlimentacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("alimentacao/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoDeRefeicao,Descricao,Horario,RefeicaoDoLixo,Id,DataDoRegistro,IdDoUsuario")] Alimentacao alimentacao)
        {
            if (ModelState.IsValid)
            {
                var loggedUserEmail = HttpContext.User.FindFirst(ClaimTypes.Email).Value;
                alimentacao.IdDoUsuario = _context.Usuarios.FirstOrDefault(a => a.Email == loggedUserEmail).Id;

                alimentacao.Id = Guid.NewGuid();

                _context.Add(alimentacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", alimentacao.IdDoUsuario);
            return View(alimentacao);
        }

        // GET: RegistrosDeAlimentacao/Edit/5
        [HttpGet("alimentacao/edit")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.RegistrosDeAlimentacao == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.RegistrosDeAlimentacao.FindAsync(id);
            if (alimentacao == null)
            {
                return NotFound();
            }
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", alimentacao.IdDoUsuario);
            return View(alimentacao);
        }

        // POST: RegistrosDeAlimentacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("alimentacao/edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("TipoDeRefeicao,Descricao,Horario,RefeicaoDoLixo,Id,DataDoRegistro,IdDoUsuario")] Alimentacao alimentacao)
        {
            if (id != alimentacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alimentacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlimentacaoExists(alimentacao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", alimentacao.IdDoUsuario);
            return View(alimentacao);
        }

        // GET: RegistrosDeAlimentacao/Delete/5
        [HttpGet("alimentacao/delete")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.RegistrosDeAlimentacao == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.RegistrosDeAlimentacao
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alimentacao == null)
            {
                return NotFound();
            }

            return View(alimentacao);
        }

        // POST: RegistrosDeAlimentacao/Delete/5
        [HttpPost("alimentacao/delete"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.RegistrosDeAlimentacao == null)
            {
                return Problem("Entity set 'AppDbContext.RegistrosDeAlimentacao'  is null.");
            }
            var alimentacao = await _context.RegistrosDeAlimentacao.FindAsync(id);
            if (alimentacao != null)
            {
                _context.RegistrosDeAlimentacao.Remove(alimentacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlimentacaoExists(Guid id)
        {
          return _context.RegistrosDeAlimentacao.Any(e => e.Id == id);
        }
    }
}
