using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        

        private NumeroBinario(string pNumero)
        {
            this.numero = pNumero;
        }

        public string SetNumero
        {
           set
            {
                this.numero = value;
            }

            get
            {
                return this.numero;
            }
        }

        #region Métodos
        
        #endregion


        #region Conversiones
        public static implicit operator NumeroBinario(string numBin)
        {
            return new NumeroBinario(numBin);
        }

        public static explicit operator string(NumeroBinario numBin)
        {
            return numBin.numero;
        }

        public static explicit operator NumeroDecimal(NumeroBinario numBin)
        {
            NumeroDecimal aux = Conversor.BinarioDecimal(numBin.numero);
            return aux;
        }


        public static string operator +(NumeroBinario numBin, NumeroDecimal numDec)
        {
            //double aux = (double)((NumeroDecimal)numBin);
            //double suma = aux + (double) numDec;


            //REUTILIZACION DE CÓDIGO.
            return Conversor.DecimalBinario(numDec + numBin);
            //SOBRECARGA DE OPERADOR + EN LA CLASE NUMERODECIMAL.
        }

        public static string operator -(NumeroBinario numBin, NumeroDecimal numDec)
        {
            StringBuilder sb = new StringBuilder();

            double aux = (double)((NumeroDecimal)numBin);
            double acumulador = default(double);

            if (aux <= (double)numDec)

            {
                acumulador = aux - (double)numDec;
                sb.AppendLine("La resta es: " + acumulador);
            }
            else
            {
                sb.AppendLine("No puede dar número negativo");
            }

            //return Conversor.DecimalBinario(suma);
            return sb.ToString();
        }


        public static bool operator ==(NumeroBinario numBin, NumeroDecimal numDec)
        {
            return (numBin.numero == ((NumeroBinario)numDec).numero);
        }

        public static bool operator !=(NumeroBinario numBin, NumeroDecimal numDec)
        {
            return !(numBin == numDec);
        }

        #endregion

    }
}
