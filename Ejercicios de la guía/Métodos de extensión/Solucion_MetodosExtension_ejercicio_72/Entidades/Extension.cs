using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static string CantidadDigitos(this long digitosNumero)
        {
            string strCantDig = $"Número de: {digitosNumero.ToString().Length} dígitos";

            return strCantDig;
        }
    }
}
