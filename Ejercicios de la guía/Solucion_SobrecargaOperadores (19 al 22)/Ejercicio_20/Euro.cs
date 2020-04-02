using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;//static igual que getCotizacion.

        #region Constructores
        static Euro()
        {
            cotizRespectoDolar = 1.16f;//1 dolar = 1,16 euros.
        }

        public Euro(double paramCantidad)
        {
            this.cantidad = paramCantidad;
        }

        public Euro(double paramCantidad, double cotizacion)
        {
            this.cantidad = paramCantidad;
            Euro.cotizRespectoDolar = cotizacion;//Como es static tengo que llamarlo sin crear una instancia.(regla de estilo)
        }
        #endregion

        #region Métodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion

        #region CONVERSIONES

        public static implicit operator Euro(double paramEuro)
        {
            Euro euroImplicit = new Euro(paramEuro);
            return euroImplicit;
        }


        #endregion

        #region COMPARACIONES

        #region Euro a Euro
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Retorna si las cantidades del primer parametro son iguales a las del segundo
        /// </summary>
        /// <param name="euro1"></param>
        /// <param name="euro2"></param>
        /// <returns>Retorna TRUE si las cantidades del primer parametro son iguales a las del segundo</returns>
        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return euro1.cantidad == euro2.cantidad;
        }

        /// <summary>
        /// Sobrecarga del operador !=.
        /// Retorna si el primer parametro es diferente al segundo.
        /// </summary>
        /// <param name="euro1"></param>
        /// <param name="euro2"></param>
        /// <returns>Retorna TRUE si el primer parametro es diferente al segundo.</returns>
        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }


        #endregion

        #region Euro a Dolar
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Retorna si las cantidades del primer parametro son iguales a las del segundo
        /// </summary>
        /// <param name="paramDolar"></param>
        /// <param name="paramEuro"></param>
        /// <returns>Retorna TRUE si las cantidades del primer parametro son iguales a las del segundo</returns>
        public static bool operator ==(Euro paramEuro, Dolar paramDolar)
        {
            return paramEuro == paramDolar;
        }

        /// <summary>
        /// sobrecarga del operador !=.
        /// retorna si el primer parametro es diferente al segundo.
        /// </summary>
        /// <param name="paramDolar"></param>
        /// <param name="paramEuro"></param>
        /// <returns>Retorna TRUE si el primer parametro es diferente al segundo.</returns>

        public static bool operator !=(Euro paramEuro, Dolar paramDolar)

        {
            return !(paramEuro == paramDolar);
        }


        #endregion

        #region Euro a Pesos
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Retorna si las cantidades del primer parametro son iguales a las del segundo
        /// </summary>
        /// <param name="paramPesos"></param>
        /// <param name="paramEuro"></param>
        /// <returns>Retorna TRUE si las cantidades del primer parametro son iguales a las del segundo</returns>
        public static bool operator ==(Euro paramEuro, Pesos paramPesos)
        {
            return paramEuro == paramPesos;
        }

        /// <summary>
        /// sobrecarga del operador !=.
        /// retorna si el primer parametro es diferente al segundo.
        /// </summary>
        /// <param name="paramPesos"></param>
        /// <param name="paramEuro"></param>
        /// <returns>Retorna TRUE si el primer parametro es diferente al segundo.</returns>

        public static bool operator !=(Euro paramEuro, Pesos paramPesos)

        {
            return !(paramEuro == paramPesos);
        }
        #endregion

        #endregion

    }
}
