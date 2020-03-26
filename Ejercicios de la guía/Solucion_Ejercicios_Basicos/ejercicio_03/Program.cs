using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            int numero;
            int contador = 0;
            int j = 0;
            int i;
            int k;
            int[] lista = new int[100];

            Console.WriteLine("Ingrese numeros de 0 a 100!");
            numero = Convert.ToInt32(Console.ReadLine());
            for (k = 1; k <= numero; k++)
            {
                contador = 0;
                for (i = 1; i <= k; i++)
                {
                    if (k % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    lista[j] = k;
                    j++;
                }
            }
            Console.WriteLine("los numeros primos q ingreso son");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();

            Console.ReadKey();

            /*char pregunta = 'b';
            int numero;
            int contador = 0;
            int j = 0;
            int i;
            int[] lista = new int[100];

            while (pregunta != 's')
            {
                Console.WriteLine("Ingrese numeros de 0 a 100!");
                numero = int.Parse(Console.ReadLine());

                for (i = 1; i < (numero + 1); i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    lista[j] = numero;
                    j++;
                }
                Console.WriteLine("desea terminar ? ingrese s sino quiere ingrese otra letra");
                pregunta = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("los numeros primos q ingreso son");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(lista[i]);
            }*/

            /*int numero;
            Console.Write("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());
            
            string numeroIngresado = string.Empty;
            int contador = 0;

            for(int i=1;i<=numero;i++)
            {
                if(numero % i == 0)//si el modulo de numeros entre i es igual a 0
                {
                    contador++;//incremento contador
                }
            }
            if(contador==2)
            {
                Console.WriteLine(numero + " ----> Es primo!");
            }
            else
            {
                Console.WriteLine("No es primo");
            }*/
        }
    }
}
