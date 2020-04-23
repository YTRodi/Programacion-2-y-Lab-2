using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        public enum TipoLLamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Properties
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructores
        public Llamada(float pDuracion, string pNroDestino, string pNroOrigen)
        {
            this.duracion = pDuracion;
            this.nroDestino = pNroDestino;
            this.nroOrigen = pNroOrigen;
        }
        #endregion

        #region Métodos
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            //tiene que ordenar ascendente.
            //es el metodo que le paso al sort, es decir, como quiero que lo ordene
            if(llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOSTRAR DESDE LLAMADA");
            sb.AppendLine("Duración: " + this.duracion);
            sb.AppendLine("Número destino: " + this.nroDestino);
            sb.AppendLine("Número origen: " + this.nroOrigen);
            
            return sb.ToString();
        }
        #endregion
    }
}
