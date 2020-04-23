using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        #region Properties
        //la propiedad está en local, como hago?
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string pOrigen, Franja miFranja, float pDuracion, string pDestino) : base(pDuracion,pDestino,pOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Métodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOSTRAR DESDE PROVINCIAL");
            sb.AppendLine("Datos de la clase base: " + base.Mostrar());
            sb.AppendLine("Costo llamada: " + this.CostoLlamada);
            sb.AppendLine("Franja horaria:" + this.franjaHoraria);

            return sb.ToString();
        }


        /// <summary>
        /// Retornará el valor de la llamada a partir de la duración y el costo de la misma.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costoCalculado = default(float);

            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoCalculado = base.Duracion * 0.99f;
                    break;

                case Franja.Franja_2:
                    costoCalculado = base.Duracion * 1.25f;
                    break;

                case Franja.Franja_3:
                    costoCalculado = base.Duracion * 0.66f;
                    break;
            }
            return costoCalculado;
        }
        #endregion

    }
}
