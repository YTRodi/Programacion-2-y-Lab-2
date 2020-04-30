using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        #region Enumerados
        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        #endregion

        #region Atributos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region Constructores
        public Botella(string marca, int capacidadML, int contenidoML)
        {
            this.contenidoML = contenidoML;
            this.capacidadML = capacidadML;
            this.marca = marca;
            if (capacidadML < contenidoML)
            {
                this.contenidoML = this.capacidadML;
            }
        }
        #endregion

        #region Properties
        //public float CapacidadLitros //SI FUERA FLOAT, DARIA BIEN LA CAPACIDAD DE LITROS
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
                //return (float)this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;//
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                //return (float)this.Contenido * 100 / this.CapacidadLitros;
                return (float)this.contenidoML * 100 / this.capacidadML; //trabajo con mililitros
            }
        }
        #endregion

        #region Métodos
        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Porcentaje de contenido: {0:0#}% \n", this.PorcentajeContenido);
            sb.AppendLine("Capacidad de mililitros: " + this.capacidadML);
            sb.AppendLine("Capacidad de litros: " + this.CapacidadLitros);
            sb.AppendLine("Contenido de mililitros: " + this.Contenido);
            sb.AppendLine("Marca: " + this.marca);
            return sb.ToString();
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return this.GenerarInforme();
        }
        #endregion
    }
}
