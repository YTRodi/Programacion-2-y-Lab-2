using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        public static int Ordenar(int num1, int num2)
        {
            if (num1 > num2)
            {
                return -1;
            }
            else if (num1 < num2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Random numRandom = new Random();
            List<int> lista = new List<int>();
            Queue<int> colaPositivos = new Queue<int>();
            Queue<int> colaNegativos = new Queue<int>();

            Stack<int> pilaPositivos = new Stack<int>();
            Stack<int> pilaNegativos = new Stack<int>();


            for (int i = 0; i < 10; i++)
            {
                lista.Add(numRandom.Next(-100, 100));
            }
            Console.WriteLine("Lista normal");
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }


            lista.Sort(Ordenar);
            Console.WriteLine("\nLista ordenada positivos:");
            foreach (int item in lista)
            {
                if(item > 0)
                {
                    Console.WriteLine(item);
                    colaPositivos.Enqueue(item);
                    pilaPositivos.Push(item);
                }
            }
            Console.WriteLine("\nLista ordenada negativos:");
            foreach (int item in lista)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                    colaNegativos.Enqueue(item);
                    pilaNegativos.Push(item);
                }
            }


            Console.WriteLine("\nMuestro cola positivos");
            foreach (int item in colaPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMuestro cola negativos");
            foreach (int item in colaNegativos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMuestro pila positivos");
            foreach (int item in pilaPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMuestro pila negativos");
            foreach (int item in pilaNegativos)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
