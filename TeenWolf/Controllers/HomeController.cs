using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TeenWolf.Models;
using TeenWolf.Services;

namespace TeenWolf.Controllers;

public class HomeController : Controller
    {
    private readonly ILogger<HomeController> _logger;
    private readonly IWolfService _wolfService;
    public HomeController(ILogger<HomeController> logger, IWolfService wolfService)
    {
        _logger = logger;
        _wolfService = wolfService;
    }
    public IActionResult Index(string tipo)
    {
        var wolfs = _wolfService.GetTeenWolfDto();
        ViewData["filter"] = string.IsNullOrEmpty(tipo) ? "all" : tipo;
        return View(wolfs);
    }
    public IActionResult Details(int Numero)
    {
        var personagem = _wolfService.GetDetailedPersonagem(Numero);
        return View(personagem);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id
                    ?? HttpContext.TraceIdentifier });
    }
}
