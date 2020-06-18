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
            long num = default(long);

            while (true)
            {
                Console.Write("Ingrese número: ");
                num = long.Parse(Console.ReadLine());
                Console.WriteLine(num.CantidadDigitos());
            }
        }
    }
}
