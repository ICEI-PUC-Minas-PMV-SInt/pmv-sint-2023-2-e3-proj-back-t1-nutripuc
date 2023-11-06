using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nutripuc.Models;

namespace nutripuc.Controllers
{
    [Route("registros")]
    public class RegistrosController : Controller
    {
        private readonly AppDbContext _context;
        public RegistrosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("atividades")]
        public async Task<IActionResult> AtividadesFisicas()
        {
            var atividadesFisicas = await _context.Registros
                .Include(r => r.AtividadeFisica)
                .Where(r => r.AtividadeFisica != null)
                .Select(r => r.AtividadeFisica)
                .ToListAsync();

            return View(atividadesFisicas);
        }

        [HttpGet("atividades/criar")]
        public IActionResult CriarAtividadeFisica()
        {
            return View("CriarAtividadeFisica");
        } 


        [HttpPost("atividades/criar")]
        public async Task<IActionResult> CriarAtividadeFisica([FromBody] AtividadeFisica atividadeFisica)
        {
            // Etapa 1: Validar Modelo
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Etapa 2: Preparar Registro (Campos não existentes no formulário)
            atividadeFisica.Id = Guid.NewGuid(); // Gerar um novo Guid
            atividadeFisica.DataDoRegistro = DateTime.UtcNow; // Definir a data e hora atuais
            atividadeFisica.IdDoUsuario = new Guid();

            // Etapa 3: Salvar Registro
            _context.Add(atividadeFisica);
            await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(AtividadesFisicas), new { id = atividadeFisica.Id }, atividadeFisica);
            return RedirectToAction("AtividadesFisicas");
        }

        [HttpGet("refeicoes")]
        public async Task<IActionResult> Refeicoes()
        {
            var refeicoes = await _context.Registros
                .Include(r => r.Alimentacao)
                .Where(r => r.Alimentacao != null)
                .Select(r => r.Alimentacao)
                .ToListAsync();

            return View(refeicoes);
        }

        [HttpGet("refeicoes/criar")]
        public IActionResult CriarRefeicao()
        {
            return View("CriarRefeicao");
        }

        [HttpPost("refeicoes")]
        public async Task<IActionResult> CriarRefeicao([FromBody] Alimentacao alimentacao)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Etapa 2: Preparar Registro (Campos não existentes no formulário)
            alimentacao.Id = new Guid();
            alimentacao.DataDoRegistro = DateTime.UtcNow;
            alimentacao.IdDoUsuario = new Guid();

            // Etapa 3: Salvar Registro
            _context.Add(alimentacao);
            await _context.SaveChangesAsync();

            return RedirectToAction("Refeicoes");
        }
    }
}
