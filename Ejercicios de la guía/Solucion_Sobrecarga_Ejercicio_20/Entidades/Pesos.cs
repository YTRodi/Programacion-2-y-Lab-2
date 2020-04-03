using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 38.33f;
        }

        public Pesos(double paramCantidad)
        {
            this.cantidad = paramCantidad;
        }

        public Pesos(double paramCantidad, double cotizacion) : this (paramCantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
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

        #region Conversiones

        public static implicit operator Pesos(double d)
        {
            //convierto el double a tipo dolar??
            //Pesos auxDolar = new Pesos(d);
            //return auxDolar;
            return new Pesos(d);
        }


        //Pesos a dolar.
        public static explicit operator Euro(Pesos p)
        {
            //Voy a necesitar hacer un casting, por lo tanto...((Euro)+var);
            /*
             * La cantidad de dolares que ingresan por parametro las multiplico por
             * el valor de la cotizacion del euro con respecto al dolar?
             */
            //return new Euro(p.cantidad / Euro.GetCotizacion());
            return (Euro)((Dolar)p); //Casteo a Dolar el peso y luego ese resultado lo casteo a Euro(tipo del retorno de la conversion).
        }

        public static explicit operator Dolar(Pesos p)
        {
            //cotizacion del dolar o cotizacion de pesos?
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        #endregion

        #region Operaciones
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }


        //Suma Peso a dolar
        public static Pesos operator +(Pesos p,Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }
        
        //Suma Peso a Euro
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }

        //Resta Peso a dolar
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }

        //Resta Peso a Euro
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }
        #endregion
    }
}
