using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //f9 se saca y se pone el breakpoint
            Console.WriteLine("Hello World");
            



            //ejemplo foreach
            string[] cualquierNombre = new string[3] { "Yago", "Joaco", "Facu" };

            //foreach (string item in cualquierNombre)
            //{
            //    Console.WriteLine();

            //}
            
            //for(int i=0;i<cualquierNombre.Length;i++)
            //{
            //    string elem = cualquierNombre[i];
            //    Console.WriteLine(elem);
            //}

            
            //EJEMPLO TRYPARSE
            do
            {
                Console.Write("Carga el valor: ");
                string aux = Console.ReadLine();

                int entero;
                if(int.TryParse(aux,out entero))
                {
                    Console.Write("El numero que ingresaste: " + entero);
                }
                
            } while (true);


            Console.ReadKey();

        }
    }
}
