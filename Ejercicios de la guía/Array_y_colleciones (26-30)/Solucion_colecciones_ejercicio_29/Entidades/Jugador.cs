using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = string.Empty;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int paramDni, string paramNombre) //: this()
        {
            this.dni = paramDni;
            this.nombre = paramNombre;
        }

        public Jugador(int paramDni, string paramNombre,int paramTotalGoles,int totalPartidos) : this(paramDni,paramNombre)
        {
            this.totalGoles = paramTotalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.partidosJugados / this.totalGoles;
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("** Datos del jugador **");
            sb.AppendLine("Dni: " + this.dni);
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Partidos jugados: " + this.partidosJugados);
            sb.AppendLine("Promedio de goles: " + GetPromedioGoles());//+ this.promedioGoles);//usarGetPromedio?
            sb.AppendLine("Total de goles: " + this.totalGoles);

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
