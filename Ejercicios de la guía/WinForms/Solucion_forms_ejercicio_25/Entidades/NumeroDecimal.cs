using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double pNumero)
        {
            this.numero = pNumero;
        }

        public double SetNumero
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

        public static implicit operator NumeroDecimal(double numDec)
        {
            return new NumeroDecimal(numDec);
        }

        public static explicit operator double(NumeroDecimal numDec)
        {
            return numDec.numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal numDec)
        {
            NumeroBinario aux = Conversor.DecimalBinario(numDec.numero);
            return aux;
        }


        //public static double operator +(NumeroDecimal numDec, NumeroBinario numBin)
        //{
        //    double aux = (double)((NumeroDecimal)numBin);
        //    return aux + (double)numDec;
        //}

        //public static double operator -(NumeroDecimal numDec, NumeroBinario numBin)
        //{
        //    double aux = (double)((NumeroDecimal)numBin);
        //    return aux - (double)numDec;
        //}
        public static double operator +(NumeroDecimal numDec, NumeroBinario numBin)
        {
            double aux = (double)((NumeroDecimal)numBin);
            double suma = aux + (double)numDec;

            return suma;
        }

        public static double operator -(NumeroDecimal numDec, NumeroBinario numBin)
        {
            double aux = (double)((NumeroDecimal)numBin);
            double suma = aux - (double)numDec;

            return suma;
        }



        public static bool operator ==(NumeroDecimal numDec, NumeroBinario numBin)
        {
            return (numDec.numero == ((NumeroDecimal)numBin).numero);
        }

        public static bool operator !=(NumeroDecimal numDec, NumeroBinario numBin)
        {
            return !(numDec == numBin);
        }

    }
}
