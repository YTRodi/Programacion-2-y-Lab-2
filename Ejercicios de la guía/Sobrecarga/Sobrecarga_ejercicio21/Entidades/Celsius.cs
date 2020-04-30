using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        //Tomo el grado celsius como partida, seria como el dolar en el ejercicio anterior.
        private double cantidad;

        public Celsius(double pCantidad)
        {
            this.cantidad = pCantidad;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }

        //public static explicit operator Fahrenheit(Celsius c)
        //{
        //    return new Fahrenheit(c.cantidad * (9 / 5) + 32);
        //}
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.getCantidad() * 9 / 5 + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            //1ro la formula deocnveir a farenheit , despues de farh a kelvin
            //ESTO SE SOLUCIONARA CON LA SOBRECARGAR DEL OPERADOR +.

            //return new Kelvin(((Fahrenheit)c+ 459.67) * 5 / 9);
            return (Kelvin)((Fahrenheit)c);
        }
        



        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return (c1.cantidad == c2.cantidad);
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1.cantidad == c2.cantidad);
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return (c.cantidad == f);
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c.cantidad == f);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return (c.cantidad == k);
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c.cantidad == k);
        }

        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.cantidad + c2.cantidad);
        }

        public static Celsius operator +(Celsius c1, Fahrenheit f)
        {
            return new Celsius(c1.cantidad + ((Celsius)f).cantidad);
        }

        public static Celsius operator +(Celsius c1, Kelvin k)
        {
            return new Celsius(c1.cantidad + ((Celsius)k).cantidad);
        }


        //-
        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.cantidad - c2.cantidad);
        }

        public static Celsius operator -(Celsius c1, Fahrenheit f)
        {
            return new Celsius(c1.cantidad - ((Celsius)f).cantidad);
        }

        public static Celsius operator -(Celsius c1, Kelvin k)
        {
            return new Celsius(c1.cantidad - ((Celsius)k).cantidad);
        }
    }
}
