using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    //explicit se usa para que los usuarios esten conscientes que una conversion se va a llevar a cabo.
    //implicit se usa para que el usurio no se de cuenta que ocurrió una conversión.
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;//static igual que getCotizacion.

        #region Constructores
        static Dolar()
        {
            cotizRespectoDolar = 1;//1 dolar. 
        }

        public Dolar(double paramCantidad)
        {
            this.cantidad = paramCantidad;
        }

        public Dolar(double paramCantidad, double cotizacion)
        {
            this.cantidad = paramCantidad;
            Dolar.cotizRespectoDolar = cotizacion;//Como es static tengo que llamarlo sin crear una instancia.(regla de estilo)
        }
        #endregion

        #region Métodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion

        #region CONVERSIONES

        public static implicit operator Dolar(double paramD)
        {
            Dolar dolarImplicit = new Dolar(paramD);
            return dolarImplicit;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro auxEuro = new Euro(d.cantidad * Euro.GetCotizacion());
            return auxEuro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos auxPeso = new Pesos(d.cantidad * Pesos.GetCotizacion());
            return auxPeso;
        }
        #endregion

        #region COMPARACIONES

        #region Dolar a dolar
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Retorna si las cantidades del primer parametro son iguales a las del segundo
        /// </summary>
        /// <param name="dolar1"></param>
        /// <param name="dolar2"></param>
        /// <returns>Retorna TRUE si las cantidades del primer parametro son iguales a las del segundo</returns>
        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return dolar1.cantidad == dolar2.cantidad;
        }

        /// <summary>
        /// Sobrecarga del operador !=.
        /// Retorna si el primer parametro es diferente al segundo.
        /// </summary>
        /// <param name="dolar1"></param>
        /// <param name="dolar2"></param>
        /// <returns>Retorna TRUE si el primer parametro es diferente al segundo.</returns>
        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }


        #endregion

        #region Dolar a Euro
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Retorna si las cantidades del primer parametro son iguales a las del segundo
        /// </summary>
        /// <param name="paramDolar"></param>
        /// <param name="paramEuro"></param>
        /// <returns>Retorna TRUE si las cantidades del primer parametro son iguales a las del segundo</returns>
        public static bool operator ==(Dolar paramDolar, Euro paramEuro)
        {
            return paramDolar == paramEuro;
        }

        /// <summary>
        /// sobrecarga del operador !=.
        /// retorna si el primer parametro es diferente al segundo.
        /// </summary>
        /// <param name="paramDolar"></param>
        /// <param name="paramEuro"></param>
        /// <returns>Retorna TRUE si el primer parametro es diferente al segundo.</returns>
        public static bool operator !=(Dolar paramDolar, Euro paramEuro)
        {
            return !(paramDolar == paramEuro);
        }



        #endregion

        #region Dolar a Peso
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Retorna si las cantidades del primer parametro son iguales a las del segundo
        /// </summary>
        /// <param name="paramDolar"></param>
        /// <param name="paramPesos"></param>
        /// <returns>Retorna TRUE si las cantidades del primer parametro son iguales a las del segundo</returns>
        public static bool operator ==(Dolar paramDolar, Pesos paramPesos)
        {
            return paramDolar == paramPesos;
        }

        /// <summary>
        /// sobrecarga del operador !=.
        /// retorna si el primer parametro es diferente al segundo.
        /// </summary>
        /// <param name="paramDolar"></param>
        /// <param name="paramPesos"></param>
        /// <returns>Retorna TRUE si el primer parametro es diferente al segundo.</returns>
        public static bool operator !=(Dolar paramDolar, Pesos paramPesos)
        {
            return !(paramDolar == paramPesos);
        }
        #endregion


        #endregion

    }
}
