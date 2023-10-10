using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nutripuc.Models;

namespace nutripuc.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;
        public UsersController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Users.ToListAsync();

            return View(dados);
        }
    }
}
