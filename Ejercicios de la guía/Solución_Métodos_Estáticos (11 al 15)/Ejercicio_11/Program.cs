using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_11;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
                int numero;
                int iteracionesFor = 3;
                int limiteMinimo = -100;
                int LimiteMaximo = 100;
                int min = 0;
                int max = 0;
                int acumulador = 0;
                bool flag = false;
            #endregion

            for (int i=0;i< iteracionesFor; i++)
            {
                Console.Write("Ingrese numero:");
                if (int.TryParse(Console.ReadLine(), out numero) && Validacion.Validar(numero, limiteMinimo, LimiteMaximo))
                {
                    int.TryParse()
                    flag = false;
                    break;
                }
                else
                {
                    acumulador += numero;
                    flag = true;
                    if (i == 0)//primer vuelta del ciclo
                    {
                        min = numero;
                        max = numero;
                    }
                    else if (numero > max)
                    {
                        max = numero;
                    }
                    else if (numero < min)
                    {
                        min = numero;
                    }
                }
            }

            if(!flag)
            {
                Console.WriteLine("noppppp, te pasate de rango, bai.");
                Console.WriteLine("Minimo: {0} -- Maximo: {1}",limiteMinimo,LimiteMaximo);
            }
            else
            {
                Console.WriteLine("El valor mínimo es: {0}", min);
                Console.WriteLine("El valor maximo es: {0}", max);
                Console.WriteLine("El promedio es: {0}", acumulador / iteracionesFor);
            }
            
            Console.ReadKey();
        }
    }
}