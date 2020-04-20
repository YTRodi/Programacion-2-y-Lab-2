using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

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

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**--Datos del auto--**");
            sb.AppendLine("Cantidad de combustible: " + this.cantidadCombustible);
            sb.AppendLine("En competencia: " + this.enCompetencia);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Número: " + this.numero);
            sb.AppendLine("Vueltas restantes: " + this.vueltasRestantes);

            return sb.ToString();
        }

    }
}
