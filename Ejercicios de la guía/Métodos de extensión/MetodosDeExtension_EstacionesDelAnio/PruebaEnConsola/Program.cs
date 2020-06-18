using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine($"{fechaActual.ObtenerPlacaCronica(Extension.EEstaciones.Verano)}");
            Console.WriteLine($"{fechaActual.ObtenerPlacaCronica(Extension.EEstaciones.Primavera)}");
            Console.WriteLine($"{fechaActual.ObtenerPlacaCronica(Extension.EEstaciones.Invierno)}");
            Console.WriteLine($"{fechaActual.ObtenerPlacaCronica(Extension.EEstaciones.Otonio)}");

            Console.ReadKey();
        }
    }
}
