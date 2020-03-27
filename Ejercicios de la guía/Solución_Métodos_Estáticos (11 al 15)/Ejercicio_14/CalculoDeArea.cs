using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double paramNumero)
        {
            //area = lado x lado = lado al cuadrado
            double resultado;
            return resultado = paramNumero * paramNumero;
        }
        
        public static double CalcularTriangulo(double paramBase, double paramAltura)
        {
            double resultado;
            return resultado = (paramBase * paramAltura) / 2;
        }

        public static double CalcularCirculo(double paramNumero)
        {
            double resultado;
            return resultado = (paramNumero * paramNumero) * Math.PI;
        }
    }
}
