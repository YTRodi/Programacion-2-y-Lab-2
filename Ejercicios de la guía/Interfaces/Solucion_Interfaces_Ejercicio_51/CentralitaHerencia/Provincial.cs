using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial<T> : Llamada, IGuardar<T>
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        #region Properties
        public override float CostoLlamada//si no lo pongo esto, sale error, porque la propiedad CostoLlamada de la clase Llamada es abstract.
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string pOrigen, Franja miFranja, float pDuracion, string pDestino)
            : base(pDuracion,pDestino,pOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Métodos
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

        #region Override
        public override bool Equals(object obj)
        {
            return (obj is Provincial<T>);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            //sb.AppendLine("-------Datos desde Provincial-------");
            sb.AppendLine("Tipo de llamada: " + this.GetType());
            sb.AppendLine("Franja horaria: " + this.franjaHoraria);
            sb.AppendLine("Costo llamada: $" + this.CostoLlamada);

            return sb.ToString();
        }
        #endregion
        #region Intereface
        public string RutaDeArchivo
        {
            get
            {
                return "Ruta Archivo";
            }
            set
            {

            }
        }
        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public T Leer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
