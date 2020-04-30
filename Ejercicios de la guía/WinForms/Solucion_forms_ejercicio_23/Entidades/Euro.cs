using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.66; 
        }

        public Euro(double paramCantidad)
        {
            this.cantidad = paramCantidad;
        }

        public Euro(double paramCantidad, double cotizacion) : this(paramCantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
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

        public static void SetCotizacion(double paramCotizacion)
        {
            Euro.cotizRespectoDolar = paramCotizacion;
        }
        #endregion

        #region Conversiones

        public static implicit operator Euro(double d)
        {
            //convierto el double a tipo dolar??
            //Euro auxEuro = new Euro(d);
            //return auxEuro;
            return new Euro(d);
        }

        public static explicit operator Pesos(Euro e)
        {
            //5
            //38,33
            //total = 5 * 38,33 ----- total = 5*1,66(cotizacion euro)
            //= 191 (5 EUROS SON 114 PESOS).----- == 8,3 ?? ME PARECE QUE DA MAL
            //PROBARRRRRRR---------------------------------------------------------------------------------
            //return new Pesos(e.cantidad / Pesos.GetCotizacion());
            return (Pesos)((Dolar)e);
        }

        public static explicit operator Dolar(Euro e)
        {
            //no iria e.cantidad / la cotizacion del dolar?
            //no daria lo mismo dividirlo o multiplicarlo?
            //return new Dolar(e.cantidad / Dolar.GetCotizacion());

            return new Dolar(e.cantidad / Euro.GetCotizacion());

        }
        #endregion

        #region Operaciones
        //Euro a Euro
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);//No hace falta ninguna conversion, no hay perdida de datos.
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }


        //Euro a Dolar
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.cantidad == (Euro)d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        //Euro a Pesos
        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.cantidad == (Euro)p);//conversion explicita.
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        //Suma: Euro a Dolar
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);//Conversion explicita de dolares y luego uso su atributo cantidad.
        }

        //Suma: Euro a pesos
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        //Resta: Euro a Dolar
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        //Resta: Euro a pesos
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        #endregion
    }
}
