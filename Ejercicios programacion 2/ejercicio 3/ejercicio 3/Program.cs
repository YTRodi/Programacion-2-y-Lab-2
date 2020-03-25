using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            int j = 0;
            int i;
            int k;
            int[] lista = new int[100];

            Console.WriteLine("Hello ingrese numeros de 0 a 100!");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero);
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


            /*char pregunta = 'b';
            int numero;
            int contador = 0;
            int j = 0;
            int i;
            int[] lista = new int[100];

            while (pregunta != 's')
            {
                Console.WriteLine("Hello ingrese numeros de 0 a 100!");
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
