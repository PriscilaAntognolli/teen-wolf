using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TeenWolf.Models;
using TeenWolf.Services;

namespace TeenWolf.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWolfService _wolfservices;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _wolfservices = wolfservices;
    }

    public IActionResult Index(string tipo)
    {
        var Wolf = _wolfservices.GetTeenWolfDto();
        ViewData["filter"] = string.IsNullOrEmpty(tipo) ? "all" : tipo;
        return View(Dto);
    }

    public IActionResult Details(int numero)
    {
        var TeenWolf = _wolfservices.GetDetailedTeenWolf();
        return View(TeenWolf);
    }

        public IActionResult = Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
