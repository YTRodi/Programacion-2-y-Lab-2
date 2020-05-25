using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MyInterfaces;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera1 cartu01 = new Cartuchera1();
            cartuchera2 cartu02 = new cartuchera2();
            bool control = false;

            Boligrafo b01 = new Boligrafo(10, ConsoleColor.Green);
            Boligrafo b02 = new Boligrafo(15, ConsoleColor.Yellow);
            Boligrafo b03 = new Boligrafo(20, ConsoleColor.Red);

            Lapiz l01 = new Lapiz(10);
            Lapiz l02 = new Lapiz(15);
            Lapiz l03 = new Lapiz(20);

            cartu01 += b01;
            cartu01 += b02;
            cartu01 += b03;
            cartu01 += l01;
            cartu01 += l02;
            cartu01 += l03;


            control = cartu01.ProbarElementos();
            Console.ReadKey();
        }
    }
}
