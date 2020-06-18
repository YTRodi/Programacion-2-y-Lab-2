using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        #region Enumerados
        public enum EEstaciones
        {
            Verano,
            Primavera,
            Invierno,
            Otonio
        }
        #endregion

        #region Métodos de extensión
        /// <summary>
        /// Método de extensión para la clase Datetime
        /// </summary>
        /// <param name="fechaInicial">Va a inyectarse acá la instancia del DateTime que invoca a este método</param>
        /// <param name="estacion"></param>
        /// <returns></returns>
        public static string ObtenerPlacaCronica(this DateTime fechaInicial, EEstaciones estacion)
        {
            string strADevolver = string.Empty;
            int diaEstacion = 21;
            int mesDeLaEstacion = default(int);//donde almaceno el mes de la estación

            switch (estacion)
            {
                case EEstaciones.Verano:
                    mesDeLaEstacion = 12;//dic
                    break;

                case EEstaciones.Primavera:
                    mesDeLaEstacion = 9;//sep
                    break;

                case EEstaciones.Invierno:
                    mesDeLaEstacion = 6;//jun
                    break;

                case EEstaciones.Otonio:
                    mesDeLaEstacion = 3;//marzo
                    break;
            }

            //con fechaDeLaEstacion veo cuantos días faltan para la próxima estación.
            DateTime fechaDeLaEstacion = new DateTime(fechaInicial.Year, mesDeLaEstacion, diaEstacion);


            if (fechaDeLaEstacion < fechaInicial)
            {
                //si este año la estación ya pasó, le agrego un año a la fecha de la estación
                fechaDeLaEstacion = fechaDeLaEstacion.AddYears(1);
            }

            TimeSpan diasRestantes = fechaDeLaEstacion - fechaInicial;

            return $"Faltan {(int)diasRestantes.TotalDays} días para el {estacion}";

        }
        #endregion
    }
}
