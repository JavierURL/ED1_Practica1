using ED1_Practica01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Practica01.Controllers
{
    public class HomeController : Controller
    {
       
            private readonly ILogger<HomeController> _logger;

            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }

            public string Index()
            {
                return "Para obtener la lista clientes agrergar a la URL --/Cliente/obtenerListaClientes--, para obtener ordenamiento por nombre /Cliente/ObtenerNombreClientes";
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