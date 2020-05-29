using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        /// <summary>
        /// Agregará información al archivo de texto ubicado en la ruta pasada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="infoAGuardar"></param>
        /// <returns></returns>
        public static bool Guardar(string ruta, string infoAGuardar)
        {
            bool agregoInfo = false;

            if (File.Exists(ruta) && !(ruta is null))
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(infoAGuardar);
                    agregoInfo = true;
                }
            }
            //else
            //{
            //    using (streamwriter sw = new streamwriter(ruta))
            //    {
            //        sw.writeline(infoaguardar);
            //        agregoinfo = true;
            //    }
            //}

            return agregoInfo;
        }

        /// <summary>
        /// Retornará el contenido del archivo ubicado en la ruta pasada como parámetro.
        /// </summary>
        /// <param name="ruta">Ruta del archivo que vamos a leer</param>
        /// <returns></returns>
        public static string Leer(string ruta)
        {
            string contenidoDelArchivo = string.Empty;

            if (File.Exists(ruta) && !(ruta is null))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenidoDelArchivo = sr.ReadToEnd();
                }
            }
            else
                throw new FileNotFoundException("No se puede encontrar el archivo especificado");

            return contenidoDelArchivo;
        }

    }
}
