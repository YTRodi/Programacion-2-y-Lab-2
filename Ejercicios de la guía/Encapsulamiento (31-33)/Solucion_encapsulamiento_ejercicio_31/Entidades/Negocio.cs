using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);//por defecto caja1
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            set
            {
                bool retorno = this + value;//value es el cliente.
            }
            get
            {
                return this.clientes.Dequeue();
                //retornará el próximo cliente en la cola de atención
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool seEncuenta = false;
            foreach(Cliente aux in negocio.clientes)
            {
                if(aux == cliente)//uso el == de cliente.
                {
                    seEncuenta = true;
                }
            }
            return seEncuenta;
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;

            if(negocio != cliente)
            {
                if (!(negocio.clientes.Contains(cliente)))
                {
                    negocio.clientes.Enqueue(cliente);//encolo el cliente a la cola.
                    retorno = true;
                }
            }
            return retorno;
        }


        public static bool operator ~(Negocio negocio)
        {
            return negocio.caja.Atender(negocio.Cliente);
        }


    }
}
