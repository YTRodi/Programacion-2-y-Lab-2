using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region Properties
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local(Llamada pLlamada, float pCosto) : this(pLlamada.NroOrigen, pLlamada.Duracion, pLlamada.NroDestino, pCosto)
        {

        }

        public Local(string pOrigen,float pDuracion, string pDestino, float pCosto) : base(pDuracion, pDestino, pOrigen)
        {
            this.costo = pCosto;
        }
        #endregion

        #region Métodos
        public string Mostrar()//arreglarlo la clase que viene.
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("MOSTRAR DESDE LOCAL");
            sb.AppendLine("Datos de la clase base: " + base.Mostrar());
            sb.AppendLine("Costo: " + this.costo);

            return sb.ToString();
        }


        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        #endregion


    }
}
