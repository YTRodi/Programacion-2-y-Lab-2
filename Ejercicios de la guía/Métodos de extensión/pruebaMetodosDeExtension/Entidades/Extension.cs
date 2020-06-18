using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /*
         
         */

        public static string SafeTrim(this string cadena)
        {
            if (!string.IsNullOrEmpty(cadena))
            {
                cadena = cadena.Trim();
            }
            return cadena;
        }
        //trim seguro
    }
}
