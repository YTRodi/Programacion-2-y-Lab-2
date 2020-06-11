using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace PruebaEnConsola__Hilos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio miNegocio = new Negocio(caja1,caja2);
            miNegocio.Clientes.Add("Karen");
            miNegocio.Clientes.Add("Raul");
            //miNegocio.Clientes.Add("Karen macho");
            //miNegocio.Clientes.Add("Pepe");


            //------------------------- THREADS -------------------------
            Thread tAsignarCajaAClientes = new Thread(miNegocio.AsignarCaja);
            tAsignarCajaAClientes.Name = "Mortal Kombat store";

            Thread tAtenderClientesCaja1 = new Thread(miNegocio.Caja1.AtenderClientes);
            tAtenderClientesCaja1.Name = "Primer caja";

            Thread tAtenderClientesCaja2 = new Thread(miNegocio.Caja2.AtenderClientes);
            tAtenderClientesCaja2.Name = "Segunda caja";

            tAsignarCajaAClientes.Start();
            tAsignarCajaAClientes.Join();//Bloquea el subproceso de llamada

            tAtenderClientesCaja1.Start();
            Thread.Sleep(1500);//Asi no se ejecutan al mismo tiempo
            tAtenderClientesCaja2.Start();

            Console.ReadKey();
        }
    }
}
