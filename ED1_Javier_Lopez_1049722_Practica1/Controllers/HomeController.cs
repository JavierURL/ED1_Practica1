using ED1_Javier_Lopez_1049722_Practica1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Javier_Lopez_1049722_Practica1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Cliente cliente1;
        private readonly Cliente cliente2;


        public HomeController(ILogger<HomeController> logger)
        {
             

            _logger = logger;
            cliente1 = new  Cliente();
           
            cliente1.Edad = 35;
            cliente1.Nombre = "Marco";
            cliente1.Profesion = "Arquitecto";
            cliente1.Nacionalidad = "Guatemalteco";
            cliente1.Ingresos = 5000;

            cliente2.Edad = 35;
            cliente2.Nombre = "Marco";
            cliente2.Profesion = "Arquitecto";
            cliente2.Nacionalidad = "Guatemalteco";
            cliente2.Ingresos = 5000;





        }


        public Cliente Index()
        {
            return cliente1; 
            return cliente2;
            
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