using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese año de inicio: ");
            int yearInit = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año de fin: ");
            int endYear = int.Parse(Console.ReadLine());

            for(int i=yearInit;i<endYear;i++)
            {
                if(i%4==0)
                {
                    Console.Write("Año bisiesto: " + i + "\n");
                }
                if(i%100 == 0)
                {
                    //Console.WriteLine("No es año bisiesto");
                    if(i%400==0)
                    {
                        Console.Write("Año bisiesto (multiplo de 400): " + i + "\n");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
