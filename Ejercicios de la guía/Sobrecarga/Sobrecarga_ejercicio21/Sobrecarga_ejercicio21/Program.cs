using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Sobrecarga_ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //celsius
            //fahrenheit
            //kelvin

            //si quiero pasar un grado celsius a kelvin, 
            //primero el celsius pasa a fahrenheit y luego a kelvin. Y VICEVERSA
            Celsius c1 = new Celsius(50);
            Celsius c2 = new Celsius(10);
            Celsius aux = c1 - c2;

            Fahrenheit f1 = new Fahrenheit(50); //DEBUGGEAR.
            Fahrenheit auxF;


            Kelvin k1 = new Kelvin(50);
            Kelvin auxK = k1 + f1;//FUNCIONA.
            //auxK = k1 + c1;
            //Console.WriteLine(auxK.getCantidad());

            //auxF = f1 + k1;
            //Console.WriteLine(auxF.getCantidad());//FUNCIONA.

            //aux = c1 + f1;//FUNCIONA.
            //Console.WriteLine(aux.getCantidad());

            //auxF = f1 + c1;
            //Console.WriteLine(auxF.getCantidad());
            //auxK = k1 + c1;
            //Console.WriteLine(auxK.getCantidad());


            //FUNCIONA TODO.
            if(k1 == c1)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.ReadKey();
        }
    }
}
