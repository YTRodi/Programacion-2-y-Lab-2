using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Properties
        /// <summary>
        /// Propiedad sólo escritura validada.
        /// </summary>
        private string SetNumero//propiedad.
        {
            set
            {
                this.numero = ValidarNumero(value);
                //value representa el valor que asignamos a la propiedad.
            }
        }
        #endregion



        #region Constructores
        public Numero()
        {
            this.numero = default(double);//le asigno 0.
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public Numero(double dblNumero) : this(dblNumero.ToString())
        {
            //Convierto el numero double en string. Asi puedo usar el constructor anterior.
        }
        #endregion



        #region Methods
        public double ValidarNumero(string strNumero)
        {
            double retornoDbl = default(double);
            if (double.TryParse(strNumero, out retornoDbl))
            {
                return retornoDbl;
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// Convierte el string binario a decimal en formato string.
        /// </summary>
        /// <param name="numBinario"></param>
        /// <returns>El numero decimal en binario.</returns>
        public static string BinarioDecimal(string numBinario)
        {
            Numero numDb = new Numero(numBinario);//instancia que me indica si todo esta ok(verificado) o no.
            int len = numBinario.Length;
            string retornoStr = string.Empty;

            if(numDb.numero > 0)
            {
                for (int i = 1; i <= len; i++)
                {
                    retornoStr += (numBinario[i - 1]) * (double)Math.Pow(2, len - i);//le saque el (double)Math.Pow
                    //retornoStr += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, len - i);
                }
            }
            else 
            {
                retornoStr = "Error inválido";
            }
            return retornoStr;
        }


        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numBin"></param>
        /// <returns>El numero decimal convertido en binario</returns>
        public static string DecimalBinario(string numBin)
        {
            Numero numDb = new Numero(numBin);
            double numeritoDb = Math.Floor(numDb.numero);//uso math.Floor para dejar la parte entera del numero.
            string retornoStrBinario = string.Empty;

            if (numeritoDb > 0)//aca va a venir un string... no tendra que venir un double??mmmm... corroborar.
            {
                while (numeritoDb > 0)
                {
                    //los num pares van a dar siempre residuos en 0 - impares residuo 1
                    retornoStrBinario = numeritoDb % 2 + retornoStrBinario;
                    numeritoDb = numeritoDb / 2;
                }
            }
            else
            {
                retornoStrBinario = "Error inválido";
            }

            return retornoStrBinario;

        }


        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numDouble"></param>
        /// <returns>El numero decimal convertido en binario</returns>
        public static string DecimalBinario(double numDouble)
        {
            //Retorna solo la parte entera.
            //Y retulizo código.
            return DecimalBinario(numDouble.ToString());//convierto el numeroDouble para poder usar la sobrecarga.
        }
        #endregion

        #region Operadores
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            double retornoDb = default(double);

            if(num2.numero == 0)
            {
                retornoDb = double.MinValue;
            }
            else
            {
                retornoDb = num1.numero / num2.numero;
            }
            return retornoDb;
        }
        #endregion



    }
}
