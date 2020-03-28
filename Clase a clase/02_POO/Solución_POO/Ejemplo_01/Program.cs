using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Ejemplo_01;

namespace Ejemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triciclo a = new Triciclo();//instancia de NombreClase.
            Triciclo b = new Triciclo();//instancia

            a.color = 10;
            b.color = 20;

            Console.WriteLine(a.GetColor());
            Console.WriteLine(b.GetColor());


            Console.WriteLine(b.GetCantidadRuedas());
            a.SetCantidadRuedas("3");//es de clase. no de instancia
            Console.WriteLine(b.GetCantidadRuedas());


            Console.ReadKey();
        }
    }
}
