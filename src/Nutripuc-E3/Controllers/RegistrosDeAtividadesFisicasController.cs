using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nutripuc_E3.Models;

namespace Nutripuc_E3.Controllers
{
    [Route("registros")]
    public class RegistrosDeAtividadesFisicasController : Controller
    {
        private readonly AppDbContext _context;

        public RegistrosDeAtividadesFisicasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RegistrosDeAtividadesFisicas
        [HttpGet("atividadefisica")]
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.RegistrosDeAtividadeFisica.Include(a => a.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: RegistrosDeAtividadesFisicas/Details/5
        [HttpGet("atividadefisica/details")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.RegistrosDeAtividadeFisica == null)
            {
                return NotFound();
            }

            var atividadeFisica = await _context.RegistrosDeAtividadeFisica
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atividadeFisica == null)
            {
                return NotFound();
            }

            return View(atividadeFisica);
        }

        // GET: RegistrosDeAtividadesFisicas/Create
        [HttpGet("atividadesfisicas/create")]
        public IActionResult Create()
        {
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: RegistrosDeAtividadesFisicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("atividadesfisicas/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TituloDoRegistro,CategoriaDaAtividade,Intensidade,Observacao,Id,DataDoRegistro,IdDoUsuario")] AtividadeFisica atividadeFisica)
        {
            if (ModelState.IsValid)
            {
                atividadeFisica.Id = Guid.NewGuid();
                _context.Add(atividadeFisica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", atividadeFisica.IdDoUsuario);
            return View(atividadeFisica);
        }

        // GET: RegistrosDeAtividadesFisicas/Edit/5
        [HttpGet("atividadesfisicas/edit")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.RegistrosDeAtividadeFisica == null)
            {
                return NotFound();
            }

            var atividadeFisica = await _context.RegistrosDeAtividadeFisica.FindAsync(id);
            if (atividadeFisica == null)
            {
                return NotFound();
            }
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", atividadeFisica.IdDoUsuario);
            return View(atividadeFisica);
        }

        // POST: RegistrosDeAtividadesFisicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("atividadesfisicas/edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("TituloDoRegistro,CategoriaDaAtividade,Intensidade,Observacao,Id,DataDoRegistro,IdDoUsuario")] AtividadeFisica atividadeFisica)
        {
            if (id != atividadeFisica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atividadeFisica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtividadeFisicaExists(atividadeFisica.Id))
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
            ViewData["IdDoUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", atividadeFisica.IdDoUsuario);
            return View(atividadeFisica);
        }

        // GET: RegistrosDeAtividadesFisicas/Delete/5
        [HttpGet("atividadesfisicas/delete")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.RegistrosDeAtividadeFisica == null)
            {
                return NotFound();
            }

            var atividadeFisica = await _context.RegistrosDeAtividadeFisica
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atividadeFisica == null)
            {
                return NotFound();
            }

            return View(atividadeFisica);
        }

        // POST: RegistrosDeAtividadesFisicas/Delete/5
        [HttpPost("atividadesfisicas/delete"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.RegistrosDeAtividadeFisica == null)
            {
                return Problem("Entity set 'AppDbContext.RegistrosDeAtividadeFisica'  is null.");
            }
            var atividadeFisica = await _context.RegistrosDeAtividadeFisica.FindAsync(id);
            if (atividadeFisica != null)
            {
                _context.RegistrosDeAtividadeFisica.Remove(atividadeFisica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtividadeFisicaExists(Guid id)
        {
          return _context.RegistrosDeAtividadeFisica.Any(e => e.Id == id);
        }
    }
}
