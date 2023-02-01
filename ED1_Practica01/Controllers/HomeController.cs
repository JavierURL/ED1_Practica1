using ED1_Practica01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Practica01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        List<Clientes> ListaDeClientes = new List<Clientes>();
        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
            ListaDeClientes.Add(new Clientes() { Nombre = "Javier", Apellido = "López", Nacionalidad = "Guatemalteco", Edad = 25, Profesion = "Ingeniero", Ingresos = 5200, Contacto = 45938711 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Marco", Apellido = "Hakimi", Nacionalidad = "Marroqui", Edad = 31, Profesion = "Arquitecto", Ingresos = 10500, Contacto = 35761293 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Diego", Apellido = "Azurdia", Nacionalidad = "Guatemalteco", Edad = 20, Profesion = "Ingeniebrio", Ingresos = 20000, Contacto = 49964833});
            ListaDeClientes.Add(new Clientes() { Nombre = "Anna", Apellido = "Murphy", Nacionalidad = "Irlandesa", Edad = 31, Profesion = "Economista", Ingresos = 3800, Contacto = 59611423});
            ListaDeClientes.Add(new Clientes() { Nombre = "Katherine", Apellido = "Mayen", Nacionalidad = "Guatemalteca", Edad = 19, Profesion = "Ingeniera", Ingresos = 10800, Contacto = 47062022 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Sebastian", Apellido = "Rangel", Nacionalidad = "Español", Edad = 21, Profesion = "Médico", Ingresos = 12000, Contacto = 42883101 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Juan Esteban", Apellido = "Rodriguez", Nacionalidad = "Guatemalteco", Edad = 19, Profesion = "Ingeniero", Ingresos = 11500, Contacto = 55069781 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Martina", Apellido = "Muralles", Nacionalidad = "Canadiense", Edad = 28, Profesion = "Abogada", Ingresos = 7500, Contacto = 35236974 });

        }

        public List<Clientes> Index()
        {
            return ListaDeClientes;
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