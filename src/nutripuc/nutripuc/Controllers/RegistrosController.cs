using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using nutripuc.Models;

[Route("registros")]
public class RegistrosController : Controller
{
    private readonly AppDbContext _context;
    public RegistrosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("atividades")]
    public async Task<ActionResult> AtividadesFisicas()
    {
        var atividadesFisicas = await _context.Registros
            .Include(r => r.AtividadeFisica)
            .Where(r => r.AtividadeFisica != null)
            .Select(r => r.AtividadeFisica)
            .ToListAsync();

        return View(atividadesFisicas);
    }

    [HttpGet("refeicoes")]
    public async Task<ActionResult> Refeicoes()
    {
        var refeicoes = await _context.Registros
            .Include(r => r.Alimentacao)
            .Where(r => r.Alimentacao != null)
            .Select(r => r.Alimentacao)
            .ToListAsync();

        return View(refeicoes);
    }
}
