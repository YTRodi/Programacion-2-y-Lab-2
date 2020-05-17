using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        #region Properties
        public short Cilindrada
        {
            set
            {
                this.cilindrada = value;
            }
            get
            {
                return this.cilindrada;
            }
        }
        #endregion

        #region Constructores
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion


        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Datos de la moto cross: ");
            sb.AppendLine("Cilindrada: " + this.Cilindrada);
            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;

            if(m1.CantidadCombustible == m2.CantidadCombustible &&
                m1.EnCompetencia == m2.EnCompetencia &&
                m1.Escuderia == m2.Escuderia &&
                m1.Numero == m2.Numero &&
                m1.VueltasRestantes == m2.VueltasRestantes)
            {
                if(m1.Cilindrada == m2.Cilindrada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        #endregion
    }
}
