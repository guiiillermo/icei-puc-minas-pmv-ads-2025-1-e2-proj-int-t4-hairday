using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;




namespace Hairday.Controllers
{


    public class BarbeiroController : Controller
    {

        private readonly AppDbContext _context;

        public BarbeiroController(AppDbContext context)
        {
            _context = context;
        }
        private string LimparDocumento(string documento)
        {
            return new string(documento?.Where(char.IsDigit).ToArray());
        }


        // GET: Consumos/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CPF_barbeiro,nome,email,senha,cidade,CNPJ_barbearia")] Barbeiro barbeiro)
        {

            barbeiro.CPF_barbeiro = LimparDocumento(barbeiro.CPF_barbeiro);
            barbeiro.CNPJ_barbearia = LimparDocumento(barbeiro.CNPJ_barbearia);


            // Verifica se o CNPJ existe antes da validação do ModelState
            bool barbeariaExiste = await _context.Barbearias
                .AnyAsync(b => b.CNPJ_barbearia == barbeiro.CNPJ_barbearia);

            if (!barbeariaExiste)
            {
                ModelState.AddModelError("CNPJ_barbearia", "CNPJ da barbearia não encontrado.");
            }

            // Verifica se o CPF já está cadastrado
            bool cpfExiste = await _context.Barbeiros
                .AnyAsync(b => b.CPF_barbeiro == barbeiro.CPF_barbeiro);

            if (cpfExiste)
            {
                ModelState.AddModelError("CPF_barbeiro", "Já existe um barbeiro cadastrado com este CPF.");
            }

            // Validação geral do modelo
            if (ModelState.IsValid)
            {
                _context.Add(barbeiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Se chegou aqui, algo deu errado
            return View(barbeiro);
        }

        public async Task<IActionResult> Index()
        {
            var barbeiros = await _context.Barbeiros.ToListAsync();
            return View(barbeiros);
        }
    }
}
