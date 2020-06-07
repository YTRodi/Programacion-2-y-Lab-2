using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDAO
{
    public class Local : Llamada
    {
        protected float costo;

        #region Properties
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Constructores
        public Local(Llamada pLlamada, float pCosto)
            : this(pLlamada.NroOrigen, pLlamada.Duracion, pLlamada.NroDestino, pCosto)
        {

        }

        public Local(string pOrigen, float pDuracion, string pDestino, float pCosto)
            : base(pDuracion, pDestino, pOrigen)
        {
            this.costo = pCosto;
        }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Tipo de llamada: " + this.GetType());
            sb.AppendLine("Costo de la llamada: $" + this.CostoLlamada);
            //sb.AppendLine("Costo: " + this.costo);

            return sb.ToString();
        }


        #endregion

        #region Interface
        //public string RutaDeArchivo
        //{
        //    get
        //    {
        //        return "Ruta Archivo";
        //    }
        //    set
        //    {

        //    }
        //}

        //public bool Guardar()
        //{
        //    throw new NotImplementedException();
        //}

        //public Local Leer()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}
