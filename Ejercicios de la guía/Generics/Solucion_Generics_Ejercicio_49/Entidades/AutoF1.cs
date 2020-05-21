using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        #region Properties
        public short CaballosDeFuerza
        {
            set
            {
                this.caballosDeFuerza = value;
            }
            get
            {
                return this.caballosDeFuerza;
            }
        }
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
            
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero,escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        #endregion


        #region Métodos
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("**--Datos del auto F1--**");
            sb.AppendLine("Caballos de fuerza: " + this.CaballosDeFuerza);

            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if (a1.CantidadCombustible == a2.CantidadCombustible &&
                a1.EnCompetencia == a2.EnCompetencia &&
                a1.Escuderia == a2.Escuderia &&
                a1.Numero == a2.Numero &&
                a1.VueltasRestantes == a2.VueltasRestantes)
            {
                if (a1.CaballosDeFuerza == a2.CaballosDeFuerza)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
