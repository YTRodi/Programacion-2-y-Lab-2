using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        public double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Pesos()
        {
            cotizRespectoDolar = 38.33f;//1 dolar = 38,33 pesos 
        }

        public Pesos(double paramCantidad)
        {
            this.cantidad = paramCantidad;
        }

        public Pesos(double paramCantidad, double cotizacion)
        {
            this.cantidad = paramCantidad;
            Pesos.cotizRespectoDolar = cotizacion;//Como es static tengo que llamarlo sin crear una instancia.(regla de estilo)
        }
        #endregion

        #region Métodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        #endregion

        #region CONVERSIONES
        public static implicit operator Pesos(double d)
        {
            Pesos pesosImplicit = new Pesos(d);
            return pesosImplicit;
        }

        //TODO.


        #endregion

        #region COMPARACIONES

        #region Pesos a Pesos

        #endregion

        #region Pesos a Dolar

        #endregion

        #region Pesos a Euros

        #endregion

        #endregion
    }








}
