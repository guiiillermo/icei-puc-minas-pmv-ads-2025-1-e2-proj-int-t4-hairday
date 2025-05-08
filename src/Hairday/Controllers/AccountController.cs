using Microsoft.AspNetCore.Mvc;
using Hairday.Models;  // ajuste o namespace se necessário
using System.Linq;
using Hairday.Controllers;

public class AccountController : Controller
{
    private readonly AppDbContext _context;

    public AccountController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string senha)
    {
        var usuario = _context.Clientes.SingleOrDefault(c => c.email == email && c.senha == senha);

        if (usuario != null)
        {
            TempData["Mensagem"] = "Login bem-sucedido!";
            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError(string.Empty, "Email ou senha inválidos.");
        return View();
    }
}
