using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double cantidad;

        public Kelvin(double pCantidad)
        {
            this.cantidad = pCantidad;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Kelvin(double c)
        {
            return new Kelvin(c);
        }

        //de fah a kelvin.
        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);//ESTE ESTA BIEN???
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.cantidad * 9 / 5) - 459.67);
        }





        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.cantidad == k2.cantidad);
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1.cantidad == k2.cantidad);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k.cantidad == c);
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k.cantidad == c);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k.cantidad == f);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k.cantidad == f);
        }

        //+
        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.cantidad + k2.cantidad);
        }

        public static Kelvin operator +(Kelvin k1, Celsius c)
        {
            return new Kelvin(k1.cantidad + ((Kelvin)c).cantidad);
        }
        public static Kelvin operator +(Kelvin k1, Fahrenheit f)
        {
            return new Kelvin(k1.cantidad + ((Kelvin)f).cantidad);
        }

        //-
        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.cantidad - k2.cantidad);
        }

        public static Kelvin operator -(Kelvin k1, Celsius c)
        {
            return new Kelvin(k1.cantidad - ((Kelvin)c).cantidad);
        }
        public static Kelvin operator -(Kelvin k1, Fahrenheit f)
        {
            return new Kelvin(k1.cantidad - ((Kelvin)f).cantidad);
        }


    }
}
