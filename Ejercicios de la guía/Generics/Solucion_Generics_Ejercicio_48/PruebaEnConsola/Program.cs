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
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Recibo recibo01 = new Recibo(1);
            Factura factura01 = new Factura(500);

            contabilidad += recibo01;
            contabilidad += factura01;

            Console.ReadKey();
        }
    }
}
