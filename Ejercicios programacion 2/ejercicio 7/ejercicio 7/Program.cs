using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;

            Console.Write("Ingrese fecha (dia,mes,anio): " );
            DateTime fechaIngresada = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Los dias vividos son: " + fechaActual.Subtract(fechaIngresada).Days);
        }
    }
}
