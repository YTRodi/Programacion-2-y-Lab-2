using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_14;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            int opcion = 0;
            double numeroUnoIngresado;
            double numeroDosIngresado;

            Console.Write("Ingrese primer numero : ");
            double.TryParse(Console.ReadLine(), out numeroUnoIngresado);
            Console.Write("Ingrese segundo numero: ");
            double.TryParse(Console.ReadLine(), out numeroDosIngresado);

            Console.WriteLine("El area del cuadrado del numero {0} es: {1} y el cuadrado del numero {2} es: {3}", numeroUnoIngresado, CalculoDeArea.CalcularCuadrado(numeroUnoIngresado),numeroDosIngresado, CalculoDeArea.CalcularCuadrado(numeroDosIngresado));
            Console.WriteLine("El area del triangulo (num1*num2)/2 es: {0}", CalculoDeArea.CalcularTriangulo(numeroUnoIngresado,numeroDosIngresado));
            Console.WriteLine("El area del circulo 1 es: {0} \nEl area del circulo 2 es: {1}", CalculoDeArea.CalcularCirculo(numeroUnoIngresado), CalculoDeArea.CalcularCirculo(numeroDosIngresado));

            Console.ReadKey();
        }
    }
}
