using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Hairday.Data;
using Hairday.Models;
using Hairday.ViewModels;

namespace Hairday.Controllers
{
    public class EscolhaServicoController : Controller
    {
        private readonly AppDbContext _context;
        public EscolhaServicoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /EscolhaServico/Detalhes?cnpj=11111111000101
        public IActionResult Detalhes(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
            {
                return NotFound("CNPJ não informado.");
            }

            var barbearia = _context.Barbearias.FirstOrDefault(b => b.CNPJ_barbearia == cnpj);

            if (barbearia == null)
            {
                return NotFound("Barbearia não encontrada.");
            }

            var barbeiros = _context.Barbeiros
                .Where(b => b.CNPJ_barbearia == cnpj)
                .Include(b => b.servicos)
                .ToList();

            var vm = new EscolhaServicoViewModel
            {
                Barbearia = barbearia,
                Barbeiros = barbeiros
            };

            return View(vm);
        }
    }
}