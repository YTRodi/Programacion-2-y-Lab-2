using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaJugadores;
        private string nombre;

        #region Constructores
        private Equipo()
        {
            this.listaJugadores = new List<Jugador>();
        }

        public Equipo(short paramCantidad, string paramNombre) : this()
        {
            this.cantidadDeJugadores = paramCantidad;
            this.nombre = paramNombre;
        }
        #endregion

        #region Métodos
        public string MostrarEquipo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** Datos del equipo ***");
            sb.AppendLine("Nombre del equipo: " + this.nombre);
            sb.AppendLine("Cantidad máxima de jugadores: " + this.cantidadDeJugadores);
            sb.AppendLine("\nLISTA DE JUGADORES:");
            sb.AppendLine("************************");

            foreach (Jugador item in listaJugadores)
            {
                sb.AppendLine(item.MostrarDatos());
            }

            return sb.ToString();
        }
        #endregion


        #region Operaciones
        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;
            foreach (Jugador aux in equipo.listaJugadores)
            {
                if (aux == jugador)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;

            if (equipo != jugador)
            {
                if (equipo.listaJugadores.Count < equipo.cantidadDeJugadores)
                {
                    if (!(equipo.listaJugadores.Contains(jugador)))
                    {
                        equipo.listaJugadores.Add(jugador);
                        retorno = true;
                    }
                    else
                    {
                        Console.WriteLine("Ya esta agregado.");
                        //si esto es false, hacer el cw en else en program.cs
                    }

                }
            }
            return retorno;
        }
        #endregion

    }
}
