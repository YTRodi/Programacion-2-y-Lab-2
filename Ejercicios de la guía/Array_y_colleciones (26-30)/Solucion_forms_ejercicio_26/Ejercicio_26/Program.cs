using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeritos = new int[10];
            Random numeritoRandom = new Random();

            for (int i = 0; i < numeritos.Length; i++)
            {
                numeritos[i] = numeritoRandom.Next(-10, 10);
            }

            Console.WriteLine("Vector tal cuál.");
            for (int i = 0; i < numeritos.Length; i++)
            {
                Console.WriteLine(numeritos[i]);
            }

            Console.WriteLine("\nPositivos ordenados en forma decreciente.");
            Array.Sort(numeritos);
            Array.Reverse(numeritos);
            for (int i = 0; i < numeritos.Length; i++)
            {
                if(numeritos[i]>0)
                {
                    Console.WriteLine(numeritos[i]);
                }
            }

            Console.WriteLine("\nNegativos ordenados en forma ascendente.");
            Array.Sort(numeritos);
            for (int i = 0; i < numeritos.Length; i++)
            {
                if (numeritos[i] < 0)
                {
                    Console.WriteLine(numeritos[i]);
                }
            }


            Console.ReadKey();
        }
    }
}
