using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1, "Camu");
            Cliente cliente2 = new Cliente(2, "Yago");
            Cliente cliente3 = new Cliente(3, "Jason");
            Cliente cliente4 = new Cliente(4, "Mario");
            Cliente cliente5 = new Cliente(5, "Luigi");
            Cliente cliente6 = new Cliente(6, "Tanjirou");
            Cliente cliente7 = new Cliente(7, "Nezuko");



            Negocio negocio = new Negocio("Panchufletas");

            if(negocio + cliente1)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (negocio + cliente2)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (negocio + cliente3)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (negocio + cliente4)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (negocio + cliente5)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (negocio + cliente6)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (negocio + cliente7)
            {
                Console.WriteLine("Cliente agregado");
            }

            Console.WriteLine("Procesando a los clientes");
            while(negocio.ClientesPendientes > 0)
            {
                if(~negocio)
                {
                    Console.WriteLine("Cliente agregado con éxito");
                }
            }


            Console.ReadKey();
        }
    }
}
