using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        //adentro de explicit uso los get.

        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double paramCantidad)
        {
            this.cantidad = paramCantidad;
        }

        public Dolar(double paramCantidad, double cotizacion) : this (paramCantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
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

        public static void SetCotizacion(double paramCotizacion)
        {
            Dolar.cotizRespectoDolar = paramCotizacion;
        }

        #endregion

        #region Conversiones

        public static implicit operator Dolar(double d)
        {
            //convierto el double a tipo dolar??
            //Dolar auxDolar = new Dolar(d);
            //return auxDolar;

            return new Dolar(d);
        }


        //DOLAR A EURO!!!!.
        public static explicit operator Euro(Dolar d)
        {
            //Voy a necesitar hacer un casting, por lo tanto...((Euro)+var);
            /*
             * La cantidad de dolares que ingresan por parametro las multiplico por
             * el valor de la cotizacion del euro con respecto al dolar?
             */
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }


        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }




        #endregion

        #region Operaciones
        //Dolar a dolar
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);//No hace falta ninguna conversion, no hay perdida de datos.
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }


        //Dolar a Euro
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.cantidad == (Dolar)e);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        //Dolar a Pesos
        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d.cantidad == (Dolar)p);//conversion explicita.
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }


        //Suma: Dolar a Euro
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);//Convierto un euro a Dolar y luego uso su atributo cantidad.
        }

        //Suma: Dolar a Pesos
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }

        //----------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------

        //Resta: Dolar a Euro
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }

        //Resta: Dolar a Pesos
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }

        #endregion
    }
}
