using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        //T = EQUIPO.
        #region Atributos
        private List<T> equipos;
        private string nombre;
        private static Random rnd = new Random();
        #endregion

        #region Constructores
        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Properties
        public string JugarPartido
        {
            get
            {
                string control = string.Empty;
                int primerIndexRnd = rnd.Next(0, this.equipos.Count);
                int segundoIndexRnd = rnd.Next(0, this.equipos.Count);

                while (this.equipos.Count >= 2 && primerIndexRnd == segundoIndexRnd)
                {
                    segundoIndexRnd = rnd.Next(0, this.equipos.Count);
                }

                return this.CalcularPartido(this.equipos[primerIndexRnd], this.equipos[segundoIndexRnd]);
            }
        }
        #endregion

        #region Métodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tTorneo: {this.nombre}");
            foreach (Equipo item in this.equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }
            return sb.ToString();
        }
        private string CalcularPartido<T>(T t1, T t2) where T : Equipo//Tienen que ser del tipo Equipo o derivadas.
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t\t\tPARTIDO");
            sb.AppendLine($"\t{t1.NombreEquipo} Cantidad de goles: {rnd.Next(1, 10)}");
            sb.AppendLine("\t\t\t   VS");
            sb.Append($"\t{t2.NombreEquipo} - Cantidad de goles: {rnd.Next(1, 10)}");
            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            bool estaEnTorneo = false;
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    estaEnTorneo = true;
                    break;
                }
            }
            return estaEnTorneo;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo != equipo)
                torneo.equipos.Add((T)equipo);

            return torneo;
        }
        #endregion
    }
}
