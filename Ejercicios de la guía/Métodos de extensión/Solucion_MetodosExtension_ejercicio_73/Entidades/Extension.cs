using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static string CantidadSignos(this string cadenaALeer)
        {
            int countPuntos = 0;
            int countComas = 0;
            int countPuntoYComa = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cadenaALeer.Length; i++)
            {
                if (cadenaALeer[i] == ',')
                    countComas++;
                else if (cadenaALeer[i] == '.')
                    countPuntos++;
                else if (cadenaALeer[i] == ';')
                    countPuntoYComa++;
            }

            sb.AppendLine($"Cantidad de comas: {countComas}");
            sb.AppendLine($"Cantidad de puntos: {countPuntos}");
            sb.AppendLine($"Cantidad de punto y coma: {countPuntoYComa}");

            return sb.ToString();
        }
    }
}
