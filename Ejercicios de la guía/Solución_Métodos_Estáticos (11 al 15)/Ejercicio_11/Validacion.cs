using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor,int minimo,int maximo)
        {
            if (valor<minimo || valor>maximo)
            {
                return true;
            }
            return false;
        }
    }
}
