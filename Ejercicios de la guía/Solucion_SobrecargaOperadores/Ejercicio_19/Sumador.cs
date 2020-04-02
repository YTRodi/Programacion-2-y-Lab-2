using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSumador
{
    class Sumador
    {
        private int cantidadSumas;
        //Punto A.
        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="paramCantidad"></param>
        public Sumador(int paramCantidad)
        {
            this.cantidadSumas = paramCantidad;
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Sumador()
        {
            cantidadSumas = 0;
        }

        //Punto B.
        //Sumar = incrementará cantidadSumas en 1
        /// <summary>
        /// Incrementa cantidadSuma en 1.
        /// Retorna la suma de los dos parametros.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>La suma de los dos parametros</returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Incrementa cantidadSuma en 1.
        /// Retorna la concatenación de los dos parametros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>La concatenación de los dos parametros</returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + " " + b;
        }

        //Punto c
        /// <summary>
        /// Conversión explicita que retorna cantidadSumas.
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga de operador +.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Retorna la suma de cantidadSumas de los dos parametros.</returns>
        public static long operator + (Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        /// <summary>
        /// Sobrecargar del operador |
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Si son iguales = true sino false.</returns>
        public static bool operator | (Sumador s1, Sumador s2)
        {
            bool retornoBool = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retornoBool = true;
            }
            return retornoBool;
        }

    }
}
