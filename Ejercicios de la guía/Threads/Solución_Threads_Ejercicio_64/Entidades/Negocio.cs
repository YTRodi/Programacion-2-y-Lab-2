using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        #region Atributos
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;
        #endregion

        #region Properties
        public Caja Caja1
        {
            get { return this.caja1; }
        }
        public Caja Caja2
        {
            get { return this.caja2; }
        }
        public List<string> Clientes
        {
            get { return this.clientes; }
        }
        #endregion

        #region Constructores
        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string>();
        }
        #endregion

        #region Métodos
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.Clientes)
            {
                /* Si la primer caja tiene menos clientes entonces el cliente
                 * que estaba en la lista pasa a estar en la caja 1. */
                if (this.caja1.FilaClientes.Count <= this.caja2.FilaClientes.Count)
                    this.caja1.FilaClientes.Add(cliente);
                else
                    this.caja2.FilaClientes.Add(cliente);
                Thread.Sleep(1000);
            }
        }
        #endregion
    }
}
