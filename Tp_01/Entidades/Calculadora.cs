using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora 
    {
        private static string ValidarOperador(string operador)
        {
            switch(operador)
            {
                case "+":
                    break;

                case "-":
                    break;

                case "/":
                    break;

                case "*":
                    break;

                default:
                    return "+";
            }
            return operador;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retornoDouble = default(double);
            switch(ValidarOperador(operador))
            {
                case "+":
                    retornoDouble = num1 + num2;
                    break;

                case "-":
                    retornoDouble = num1 - num2;
                    break;

                case "/":
                    retornoDouble = num1 / num2;
                    break;

                case "*":
                    retornoDouble = num1 * num2;
                    break;
            }
            return retornoDouble;
        }

    }
}
