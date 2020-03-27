using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_15;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: meter un while para que el usuario elija cuando dejar de ingresar datos.
            double num1;
            double num2;
            string opcion = string.Empty;

            Console.Write("Ingrese primer numero: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Ingrese segundo numero: ");
            double.TryParse(Console.ReadLine(), out num2);

            Console.Write("Elegi la opcion (+,-,*,/): ");
            opcion = Console.ReadLine();
            switch(opcion)
            {
                case "+":
                    Console.WriteLine("La suma de los numeros es: {0}", Calculadora.Calcular(num1,num2,"+"));
                    break;
                case "-":
                    Console.WriteLine("La resta de los numeros es: {0}", Calculadora.Calcular(num1, num2, "-"));
                    break;

                case "*":
                    Console.WriteLine("La multiplicacion de los numeros es: {0}", Calculadora.Calcular(num1, num2, "*"));
                    break;

                case "/":
                    Console.WriteLine("La division de los numeros es: {0}", Calculadora.Calcular(num1, num2, "/"));
                    break;
            }

            Console.ReadKey();

        }
    }
}
