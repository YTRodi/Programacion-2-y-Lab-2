using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            char confirma;
            int numero;
            int acumulador = 0;
            do
            {
                Console.Write("Ingrese numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                acumulador += numero;

                Console.WriteLine("Desea continuar agregando numeros? <s-n>:");
                confirma = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidarS_N(confirma));

            Console.WriteLine("La suma total es: " + acumulador);
            Console.ReadKey(); 
        }
    }
}
