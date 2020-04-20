using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;//o será ++numeroActual?
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Cliente: " + cli.Nombre);
            Console.WriteLine("Numero: " + cli.Numero);

            System.Threading.Thread.Sleep(2000);

            return true;   
        }
    }
}
