using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nSumador;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumaUno = new Sumador();
            Sumador sumaDos = new Sumador();

            sumaUno.Sumar(5, 5);
            sumaUno.Sumar("pepe", "luis");
            //aca cantidad sumas de resultadoUno tendria que ser 2.

            sumaDos.Sumar(10, 10);
            sumaDos.Sumar("Juan", "Carlos");
            //aca cantidad sumas de resultadoUno tendria que ser 2.

            Console.WriteLine(sumaUno + sumaDos);

            //si tienen el mismo cantidadSuma (osea las dos variables ejecutan la misma CANTIDAD de métodos).
            Console.WriteLine(sumaUno | sumaDos);

            Console.ReadKey();
        }
    }
}
