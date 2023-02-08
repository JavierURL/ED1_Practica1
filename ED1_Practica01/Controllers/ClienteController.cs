using ED1_Practica01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Practica01.Controllers
{

    [Route("[controller]")]
    public class ClienteController : Controller
    {


        public List<Clientes> ListaDeClientes = new List<Clientes>();

        [HttpGet]
        [Route("obtenerListaClientes")]
        public List<Clientes> mostrarlista()
        {

           
            ListaDeClientes.Add(new Clientes() { Nombre = "Javier", Apellido = "López", Nacionalidad = "Guatemalteco", Edad = 25, Profesion = "Ingeniero", Ingresos = 5200, Contacto = 45938711 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Marco", Apellido = "Hakimi", Nacionalidad = "Marroqui", Edad = 31, Profesion = "Arquitecto", Ingresos = 10500, Contacto = 35761293 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Diego", Apellido = "Azurdia", Nacionalidad = "Guatemalteco", Edad = 20, Profesion = "Ingeniero", Ingresos = 20000, Contacto = 49964833});
            ListaDeClientes.Add(new Clientes() { Nombre = "Anna", Apellido = "Murphy", Nacionalidad = "Irlandesa", Edad = 31, Profesion = "Economista", Ingresos = 3800, Contacto = 59611423});
            ListaDeClientes.Add(new Clientes() { Nombre = "Katherine", Apellido = "Mayen", Nacionalidad = "Guatemalteca", Edad = 19, Profesion = "Ingeniera", Ingresos = 10800, Contacto = 47062022 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Sebastian", Apellido = "Rangel", Nacionalidad = "Español", Edad = 21, Profesion = "Médico", Ingresos = 12000, Contacto = 42883101 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Juan Esteban", Apellido = "Rodriguez", Nacionalidad = "Guatemalteco", Edad = 19, Profesion = "Ingeniero", Ingresos = 11500, Contacto = 55069781 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Martina", Apellido = "Muralles", Nacionalidad = "Canadiense", Edad = 28, Profesion = "Abogada", Ingresos = 7500, Contacto = 35236974 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Lucia", Apellido = "Gomez", Nacionalidad = "Africana", Edad = 56, Profesion = "Auditora", Ingresos = 6400, Contacto = 26457893 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Amelia", Apellido = "Velasquez", Nacionalidad = "Polaca", Edad = 24, Profesion = "Nutricionista", Ingresos = 3800, Contacto = 45781230 });

            return ListaDeClientes;
        }



        [HttpGet]
        [Route("ObtenerNombreClientes")]
        public List<Clientes> OrdernarClientes()
        {
            ListaDeClientes.Add(new Clientes() { Nombre = "Javier", Apellido = "López", Nacionalidad = "Guatemalteco", Edad = 25, Profesion = "Ingeniero", Ingresos = 5200, Contacto = 45938711 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Carlos", Apellido = "Hakimi", Nacionalidad = "Marroqui", Edad = 31, Profesion = "Arquitecto", Ingresos = 10500, Contacto = 35761293 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Diego", Apellido = "Azurdia", Nacionalidad = "Guatemalteco", Edad = 20, Profesion = "Ingeniero", Ingresos = 20000, Contacto = 49964833 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Anna", Apellido = "Murphy", Nacionalidad = "Irlandesa", Edad = 31, Profesion = "Economista", Ingresos = 3800, Contacto = 59611423 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Katherine", Apellido = "Mayen", Nacionalidad = "Guatemalteca", Edad = 19, Profesion = "Ingeniera", Ingresos = 10800, Contacto = 47062022 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Sebastian", Apellido = "Rangel", Nacionalidad = "Español", Edad = 21, Profesion = "Médico", Ingresos = 12000, Contacto = 42883101 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Juan Esteban", Apellido = "Rodriguez", Nacionalidad = "Guatemalteco", Edad = 19, Profesion = "Ingeniero", Ingresos = 11500, Contacto = 55069781 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Martina", Apellido = "Muralles", Nacionalidad = "Canadiense", Edad = 28, Profesion = "Abogada", Ingresos = 7500, Contacto = 35236974 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Lucia", Apellido = "Gomez", Nacionalidad = "Africana", Edad = 56, Profesion = "Auditora", Ingresos = 6400, Contacto = 26457893 });
            ListaDeClientes.Add(new Clientes() { Nombre = "Amelia", Apellido = "Velasquez", Nacionalidad = "Polaca", Edad = 24, Profesion = "Nutricionista", Ingresos = 3800, Contacto = 45781230 });

            ListaDeClientes.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            return ListaDeClientes; 
        }
    }
}
