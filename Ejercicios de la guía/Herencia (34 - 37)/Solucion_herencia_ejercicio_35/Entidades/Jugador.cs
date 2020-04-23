using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #region Properties
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                if(this.partidosJugados > 0)
                {
                    return (float)this.partidosJugados / this.TotalGoles; //partidojugados / total goles
                }
                else
                {
                    return 0;//si no jugo ningun partido y quiero saber el promedio. es 0 por defecto.
                }
                
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }
        #endregion


        #region Constructores
        //private Jugador()
        //{
        //    this.dni = 0;
        //    this.nombre = string.Empty;
        //    this.partidosJugados = 0;
        //    this.totalGoles = 0;
        //}

        public Jugador(int paramDni, string paramNombre) : base(paramDni,paramNombre) //: this()
        {
        }

        public Jugador(int paramDni, string paramNombre, int paramTotalGoles, int totalPartidos) : this(paramDni, paramNombre)
        {
            this.TotalGoles = paramTotalGoles;
            this.PartidosJugados = totalPartidos;
        }
        #endregion


        #region Métodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la persona:");
            sb.AppendLine(base.MostrarDatos());//muetra solo el dni y el nombre.

            sb.AppendLine("** Datos del jugador **");
            sb.AppendLine("Partidos jugados: " + this.PartidosJugados);
            sb.AppendLine("Promedio de goles: " + this.PromedioGoles);//+ this.promedioGoles);//usarGetPromedio?
            sb.AppendLine("Total de goles: " + this.TotalGoles);

            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Dni == j2.Dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion


    }
}
