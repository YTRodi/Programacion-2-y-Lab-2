using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio nº 2
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero>0)
            {
                Console.WriteLine("El cuadrado del numero " + numero + " es: " + Math.Pow(numero, 2));
                Console.WriteLine("El cubo del numero " + numero + " es: " + Math.Pow(numero, 3));
                //Math.Pow(numero, 2);
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
