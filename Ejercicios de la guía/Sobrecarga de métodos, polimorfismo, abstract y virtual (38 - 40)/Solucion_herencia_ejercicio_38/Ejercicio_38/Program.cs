using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2017"; 

            Sobreescrito sobrecarga = new Sobreescrito();

            Console.WriteLine(sobrecarga.ToString());

            string objeto = "¡Este es mi método ToString sobreescrito!";

            Console.WriteLine("----------------------------------------------"); 

            Console.Write("Comparación Sobrecargas con String: "); 
            Console.WriteLine(sobrecarga.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}
