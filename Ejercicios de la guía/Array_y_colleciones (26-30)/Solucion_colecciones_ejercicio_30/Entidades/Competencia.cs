using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> listaAutos;

        private Competencia()
        {
            listaAutos = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DE LA COMPETENCIA");
            sb.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            sb.AppendLine("---------------------------");
            sb.AppendLine("\nCOMPETIDORES:\n");
            sb.AppendLine("---------------------------");

            foreach (AutoF1 aux in listaAutos)
            {
                sb.AppendLine(aux.MostrarDatos());
            }

            return sb.ToString();
        }


        public static bool operator ==(Competencia competencia, AutoF1 auto)
        {
            bool retorno = false;
            foreach (AutoF1 item in competencia.listaAutos)
            {
                if(item == auto)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }

        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            bool retorno = false;
            Random numRandom = new Random();

            if(competencia.listaAutos.Count < competencia.cantidadCompetidores)
            {
                if(!(competencia.listaAutos.Contains(auto)))
                {
                    competencia.listaAutos.Add(auto);

                    auto.EnCompetencia = true;
                    auto.VueltasRestantes = competencia.cantidadVueltas;
                    auto.CantidadCombustible = (short)numRandom.Next(15, 100);

                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            bool retorno = false;

            if (!(competencia.listaAutos.Contains(auto)))
            {
                competencia.listaAutos.Remove(auto);
                retorno = true;
            }

            return retorno;
        }
    }
}
