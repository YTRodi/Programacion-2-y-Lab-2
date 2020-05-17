using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Prueba_en_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Receta recetita = new Receta(50);
            Pera pera1 = new Pera("pera 1", 50, "Verde");
            Pera pera2 = new Pera("pera 2", 10, "Amarilla");

            bool pudo = false;
            pudo = recetita + pera1;
            pudo = recetita + pera2;

            Console.ReadKey();
        }
    }
}
