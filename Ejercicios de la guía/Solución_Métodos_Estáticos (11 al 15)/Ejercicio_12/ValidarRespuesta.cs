using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            if(c == 's' || c == 'S')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
