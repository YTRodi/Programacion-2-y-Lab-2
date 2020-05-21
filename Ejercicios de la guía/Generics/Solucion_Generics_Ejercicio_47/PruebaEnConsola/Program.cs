using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> torneoFutbol = new Torneo<Equipo>("Torneito fuchibol");
            Torneo<Equipo> torneoBasquet = new Torneo<Equipo>("Torneito basquet");

            EquipoFutbol eqFutbol_01 = new EquipoFutbol("Boca", new DateTime(1905, 03, 05));
            EquipoFutbol eqFutbol_02 = new EquipoFutbol("Independiente", new DateTime(1905, 01, 01));
            EquipoFutbol eqFutbol_03 = new EquipoFutbol("River", new DateTime(1905, 05, 25));

            EquipoBasquet eqBasquet_01 = new EquipoBasquet("San Antonio Spurs", new DateTime(1967, 05, 11));
            EquipoBasquet eqBasquet_02 = new EquipoBasquet("Chicago Bulls", new DateTime(1966, 03, 25));
            EquipoBasquet eqBasquet_03 = new EquipoBasquet("Lakers", new DateTime(1947, 07, 02));

            //agrego a TorneoFutbol (act)
            torneoFutbol += eqFutbol_01;
            torneoFutbol += eqFutbol_02;
            torneoFutbol += eqFutbol_03;
            //Muestro
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine("...........................................................");
            //agrego a TorneoBasquet (act)
            torneoBasquet += eqBasquet_01;
            torneoBasquet += eqBasquet_02;
            torneoBasquet += eqBasquet_03;

            //Muestro
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.ReadKey();
        }
    }
}
