using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double num1, double num2, string operacion)
        {
            double resultado = 0;
            if(operacion == "+")
            {
                resultado = num1 + num2;
                //return resultado;
            }
            if(operacion == "-")
            {
                resultado = num1 - num2;
            }
            if (operacion == "*")
            {
                resultado = num1 * num2;
            }
            if (operacion == "/")
            {
                //VALIDAR DIVISIONNN CON METODO VALIDAR!!
                resultado = num1 / num2;
            }
            return resultado;
        }
    }
}
