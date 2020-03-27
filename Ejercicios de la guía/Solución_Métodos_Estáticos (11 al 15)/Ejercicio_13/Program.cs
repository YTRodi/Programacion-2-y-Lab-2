using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_13;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            int numeroDecimalIngresado;
            string numeroBinarioIngresado = string.Empty;
            Console.Write("Ingrese numero decimal: ");
            int.TryParse(Console.ReadLine(), out numeroDecimalIngresado);

            Console.Write("Ingrese numero binario: ");
            numeroBinarioIngresado = Console.ReadLine();

            Console.WriteLine("Numero en binario: " + Conversor.DecimalBinario(numeroDecimalIngresado));
            Console.WriteLine("Numero en binario: " + Conversor.BinarioDecimal(numeroBinarioIngresado));
            Console.ReadKey();
        }
    }
}
