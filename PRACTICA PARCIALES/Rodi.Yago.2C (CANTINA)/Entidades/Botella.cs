using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            //sb.AppendLine(string.Format("DATOS DEL FORMULARIO NÚMERO: ", this.))´;
            //sb.AppendLine(string.Format("BEBIDA NÚMERO: ", this.));
            sb.AppendLine(string.Format("Porcentaje de contenido: {0:0#}%", this.PorcentajeContenido));
            sb.AppendLine(string.Format("Capacidad de mililitros: {0}", this.capacidadML));
            sb.AppendLine(string.Format("Capacidad de litros: {0}", this.CapacidadLitros));
            sb.AppendLine(string.Format("Contenido de mililitros: {0}", this.Contenido));
            sb.AppendLine(string.Format("Marca: " + this.marca));

            return sb.ToString();


            //sb.AppendFormat("Porcentaje de contenido: {0:0#}% \n", this.PorcentajeContenido);
            //sb.AppendLine("Capacidad de mililitros: " + this.capacidadML);
            //sb.AppendLine("Capacidad de litros: " + this.CapacidadLitros);
            //sb.AppendLine("Contenido de mililitros: " + this.Contenido);
            //sb.AppendLine("Marca: " + this.marca);
            //return sb.ToString();
        }
        #endregion

        #region Override
        //4)a)
        //public override string ToString()
        //{
        //    return this.GenerarInforme();
        //}
        #endregion

        //PARTE 2 PARCIAL
        #region Conversiones
        public static bool operator ==(Botella b1, Botella b2)
        {
            return (b1.marca == b2.marca);
        }
        public static bool operator !=(Botella b1, Botella b2)
        {
            return !(b1 == b2);
        }

        public static implicit operator string(Botella botellita)
        {
            return botellita.GenerarInforme();
        }
        #endregion
    }
}
