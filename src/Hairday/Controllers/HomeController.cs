using System.Diagnostics;
using Hairday.Controllers;
using HairDay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HairDay.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

       

        public async Task<IActionResult> BuscarBarbearia()
    {
        var barbearias = await _context.Barbearias.ToListAsync();

        if (barbearias == null || !barbearias.Any())
        {
            ViewBag.Mensagem = "Nenhuma barbearia encontrada.";
            return View();
        }

        return View(barbearias);
    }


        public async Task<IActionResult> BuscarBarbeariaPorNome(string nome)
        {
            var barbearias = await _context.Barbearias
                .Where(b => b.Nome.Contains(nome))
                .ToListAsync();

            if (!barbearias.Any())
            {
                ViewBag.Mensagem = "Nenhuma barbearia encontrada com esse nome.";
                return View(new List<Barbearia>());
            }

            return View(barbearias);
        }



        public IActionResult Index()
        {
            return View();
        }

    }
}
