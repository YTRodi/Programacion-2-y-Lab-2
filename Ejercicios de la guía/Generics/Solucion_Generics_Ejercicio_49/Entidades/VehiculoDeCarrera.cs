using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Properties
        public short CantidadCombustible
        {
            set
            {
                this.cantidadCombustible = value;
            }
            get
            {
                return this.cantidadCombustible;
            }
        }

        public bool EnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }
            get
            {
                return this.enCompetencia;
            }
        }

        public string Escuderia
        {
            set
            {
                this.escuderia = value;
            }
            get
            {
                return this.escuderia;
            }
        }

        public short Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public short VueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }
            get
            {
                return this.vueltasRestantes;
            }
        }
        #endregion

        #region Constructores
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }
        #endregion

        #region Métodos
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**--Datos del Vehiculo--**");
            sb.AppendLine("Cantidad de combustible: " + this.CantidadCombustible);
            sb.AppendLine("En competencia: " + this.EnCompetencia);
            sb.AppendLine("Escuderia: " + this.Escuderia);
            sb.AppendLine("Número: " + this.Numero);
            sb.AppendLine("Vueltas restantes: " + this.VueltasRestantes);
            //si fuera auto, tendria que mostrarme los caballos de fuerza

            return sb.ToString();
        }
        #endregion
    }
}
