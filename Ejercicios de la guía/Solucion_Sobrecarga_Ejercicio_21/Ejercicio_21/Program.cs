using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //debido a sus constructores privados, no pueden usarse fuera su ámbito.
            NumeroBinario numBinario = "1010";
            NumeroDecimal numDecimal = 10;

            //conversiones explicitas ok
            string aux = (string)numBinario;
            double auxi = (double)numDecimal;
            Console.WriteLine("El numero binario es: " + aux);
            Console.WriteLine("El numero decimal es: " + auxi);

            Console.WriteLine("---------------------------------");

            //binario (+ y -) ok
            Console.Write("Binario + decimal: ");
            Console.WriteLine(numBinario + numDecimal);//funca.
            Console.Write("Binario - decimal: ");
            Console.WriteLine(numBinario - numDecimal);//funca. 

            Console.WriteLine("---------------------------------");

            //decimal (+ y -) ok
            Console.Write("Decimal + binario: ");
            Console.WriteLine(numDecimal + numBinario);//funca
            Console.Write("Decimal - binario: ");
            Console.WriteLine(numDecimal - numBinario);//funca


            Console.WriteLine("---------------------------------");


            if (numBinario == numDecimal)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }


            Console.ReadKey();
        }
    }
}
