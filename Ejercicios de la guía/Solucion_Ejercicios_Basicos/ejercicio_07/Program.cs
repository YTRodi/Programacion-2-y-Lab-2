using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            DateTime fechaActual = DateTime.Now;

            Console.Write("Ingrese fecha (dia,mes,anio): ");
            DateTime fechaIngresada = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Los dias vividos son: " + fechaActual.Subtract(fechaIngresada).Days);
            Console.ReadKey();
            
        }
    }
}
