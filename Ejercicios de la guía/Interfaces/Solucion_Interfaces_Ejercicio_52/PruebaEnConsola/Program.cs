using Entidades;
using MétodoEscrituraWrapper;
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(4, ConsoleColor.Green);

            //Lapiz
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");

            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            //Boligrafo
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Holis");//escribe
            //EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("PalabraMuyLarga");//No escribe por falta de tinta

            if (miBoligrafo.UnidadesDeEscritura >= 0)
            {
                miBoligrafo.Recargar(100);
                Console.ForegroundColor = eBoligrafo.color;
                Console.WriteLine(eBoligrafo.texto);
                Console.ForegroundColor = colorOriginal;
                Console.WriteLine(miBoligrafo);
            }
            else
                Console.WriteLine("(BOLIGRAFO)No dispone de tinta suficiente para escribir esa/s palabra/s");



            Console.ReadKey();
        }
    }
}
