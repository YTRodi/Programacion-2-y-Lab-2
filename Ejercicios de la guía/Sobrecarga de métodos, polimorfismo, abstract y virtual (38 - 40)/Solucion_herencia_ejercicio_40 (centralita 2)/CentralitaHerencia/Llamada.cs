using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
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

        public abstract float CostoLlamada
        {
            get;
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

        //public string Mostrar()
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n-------Datos desde la Llamada-------");
            sb.AppendLine("Duración: " + this.Duracion);
            sb.AppendLine("Número destino: " + this.NroDestino);
            sb.AppendLine("Número origen: " + this.NroOrigen);
            
            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if(l1.Equals(l2))
            {
                if(l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino)
                {
                    retorno = false; 
                }
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
