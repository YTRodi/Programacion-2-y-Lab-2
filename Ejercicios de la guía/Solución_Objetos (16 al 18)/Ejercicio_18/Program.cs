using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = -500;//de -500 me lo pasa a 500 positivo..
            //Console.WriteLine("numero absoluto: " + Math.Abs(numero));
            //Console.WriteLine("valor absoluto de -50000: " + Math.Abs(-50000));
            Punto puntoUno = new Punto(0, 0);
            Punto puntoDos= new Punto(20, 50);

            Rectangulo rectanguloUno = new Rectangulo(puntoUno, puntoDos);

            Console.WriteLine("El area del triangulo uno es: " + rectanguloUno.getArea()); 
            //Console.WriteLine(rectanguloUno.getArea());
            //Console.WriteLine("Ingrese area: ");
            //int.TryParse(Console.ReadLine(), out area);

            //Console.WriteLine("Ingrese perimetro: ");
            //int.TryParse(Console.ReadLine(), out perimetro);


            Console.ReadKey();
        }
    }
}
