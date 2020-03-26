using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {

        static void Main(string[] args)
        {
            Example ejemplito = new Example();
            ejemplito.Metodo(5);
            Console.ReadKey();

            /*int numeros;
            double acumulador = 0;
            string entrada = string.Empty;
            int max = 0;
            int min = 0;
            int totalNumeros = 5;
            
            for(int i=0;i<totalNumeros; i++)
            {
                Console.WriteLine("Ingrese un número:");
                entrada = Console.ReadLine();
                bool isValid = Int32.TryParse(entrada, out numeros);
                if(isValid)//true
                {
                    acumulador = acumulador + numeros;
                    if(i==0)
                    {
                        max = numeros;
                        min = numeros;
                    }
                    else if(numeros > max)
                    {
                        max = numeros;
                    }
                    else//numeros < min
                    {
                        min = numeros;
                    }
                }
            }
            Console.WriteLine("El numero mínimo es: {0}",min);
            Console.WriteLine("El numero máximo es: {0}",max);
            Console.WriteLine("El promedio de los números es: {0}",acumulador/totalNumeros);
            */
        }
    }

    class Example
    {
        private int velocidadLimite = 90;
        public void Metodo(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }

        public int modificarVelocidadLimite(int newLimit)
        {
            return velocidadLimite = newLimit;
        }
    }
}
