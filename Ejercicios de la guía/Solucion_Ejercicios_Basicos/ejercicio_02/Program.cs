using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El cuadrado del numero " + numero + " es: " + Math.Pow(numero, 2));
                Console.WriteLine("El cubo del numero " + numero + " es: " + Math.Pow(numero, 3));
                //Math.Pow(numero, 2);
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
