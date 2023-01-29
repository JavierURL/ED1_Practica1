using ED1_Practica01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Practica01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Cliente cliente1;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            cliente1 = new Cliente();

            cliente1.Edad = 35;
            cliente1.Nombre = "Marco";
            cliente1.Profesion = "Arquitecto";
            cliente1.Nacionalidad = "Guatemalteco";
            cliente1.Ingresos = 5000;
        }

        public Cliente Index()
        {
            return cliente1;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}