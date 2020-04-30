using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numDeci"></param>
        /// <returns>El numero decimal convertido en binario</returns>
        public static string DecimalBinario(double numDeci)
        {
            string retornoDeciBinario = string.Empty;

            while (numDeci != 0)
            {
                ////los num pares van a dar siempre residuos en 0 - impares residuo 1
                if (numDeci % 2 == 0)
                {
                    retornoDeciBinario = "0" + retornoDeciBinario;
                }
                else
                {
                    retornoDeciBinario = "1" + retornoDeciBinario;
                }
                numDeci /= 2;
                numDeci = Math.Floor(numDeci);
            }

            return retornoDeciBinario;
        }


        /// <summary>
        /// Convierte el string binario a decimal.
        /// </summary>
        /// <param name="numBinario"></param>
        /// <returns>El numero decimal en binario.</returns>
        public static double BinarioDecimal(string numBinario)
        {
            double aux = default(double);
            double.TryParse(numBinario, out aux);
            int residuo = 0;
            int exponente = 0;
            double acumulador = default(double);

            do
            {
                residuo = (int)aux % 10;
                aux = aux / 10;
                aux = Math.Floor(aux);
                acumulador += (double)(residuo * Math.Pow(2, exponente));
                exponente++;

            } while (aux != 0);

            return acumulador;
        }
    }
}
