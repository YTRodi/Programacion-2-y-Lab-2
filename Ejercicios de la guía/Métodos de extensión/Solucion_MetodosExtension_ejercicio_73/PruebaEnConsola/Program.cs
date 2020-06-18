using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaPuntos = "Hola..Mundo";
            string cadenaComas = ",,,HolaMundo";
            string cadenaPuntosYComas = "Hola Mundo;;;;";
            string cadenaConTodo = ".Hola;;Mundo,,,";

            //Console.WriteLine("HOLA..".CantidadSignos());

            Console.WriteLine($"CADENA PUNTOS: {cadenaPuntos}");
            Console.WriteLine(cadenaPuntos.CantidadSignos());

            Console.WriteLine($"CADENA COMAS: {cadenaComas}");
            Console.WriteLine(cadenaComas.CantidadSignos());

            Console.WriteLine($"CADENA PUNTOS Y COMAS: {cadenaPuntosYComas}");
            Console.WriteLine(cadenaPuntosYComas.CantidadSignos());

            Console.WriteLine($"CADENA CON TODO: {cadenaConTodo}");
            Console.WriteLine(cadenaConTodo.CantidadSignos());

            Console.ReadKey();
        }
    }
}
