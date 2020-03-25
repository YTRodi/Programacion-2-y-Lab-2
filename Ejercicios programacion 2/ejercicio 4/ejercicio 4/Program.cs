using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosEncontrados = 0;
            int sumaDivisores;

            for(int i = 1; numerosEncontrados < 4; i++)
            {
                sumaDivisores = 0;

                for(int j = i-1; j>0; j--)
                {
                    if(i % j == 0)
                    {
                        sumaDivisores += j;
                    }
                }

                if(sumaDivisores==i)
                {
                    Console.WriteLine("Numero perfecto: {0}", i);
                    numerosEncontrados++;
                }                
            }
            Console.ReadKey();

                //JOACO
                /*
                int cantNumero = 0;
                int acumulador = 0;
                int j = 6;
                int i;

                while (cantNumero < 4)
                {

                    for (i = 1; i < j; i++)
                    {
                        if (j % i == 0)
                        {
                            acumulador += i;
                        }
                    }

                    if (acumulador == j)
                    {
                        Console.WriteLine(acumulador);
                        cantNumero++;
                    }
                    j++;
                    acumulador = 0;
                }
                Console.ReadKey();
                */
            
        }
    }
}
