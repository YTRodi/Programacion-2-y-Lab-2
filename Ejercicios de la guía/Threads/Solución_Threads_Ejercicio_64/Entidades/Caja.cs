using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        #region Atributos
        private List<string> filaClientes;
        #endregion

        #region Properties
        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }
        #endregion

        #region Constructores
        public Caja()
        {
            filaClientes = new List<string>();
        }
        #endregion

        #region Métodos
        public void AtenderClientes()
        {
            foreach (string unCliente in this.FilaClientes)
            {
                Console.WriteLine($"Atendiendo a {unCliente} en la {Thread.CurrentThread.Name}");
                Thread.Sleep(2000);
                //Console.WriteLine("Tiempo atentiendo al cliente (2 segundos)");
            }
        }
        #endregion
    }
}
