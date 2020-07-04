using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

//Tengo que implementar el namespace con una directiva using
using Métodos_de_extensión;

namespace Métodos_de_extensión
{
    public static class GyLString
    {
        #region Paths estáticos
        public static string pathLog = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt";
        public static string fechaLog = "\nFECHA: " + DateTime.Now.ToString($"dddd dd 'de' MMMM 'de' yyyy HH:mm 'hr'");
        #endregion

        #region Método
        /// <summary>
        /// Método que extiende la clase string y escribe en un archivo de texto los datos a guardar.
        /// (Va a guardar los errores que vayan sucediendo en el programa (log.txt)).
        /// 
        /// Verificando que:
        ///  Si el archivo existe -> Lo sobrescribe.
        ///  Si no existe el archivo -> Lo crea.
        /// 
        /// Si pudo guardar, el archivo se encontrará en el escritorio.
        /// 
        /// </summary>
        /// <param name="datosAGuardar"></param>
        /// <param name="pathSalida"></param>
        /// <returns>Si pudo guardar o no.</returns>
        public static bool Guardar(this string datosAGuardar, string pathSalida)
        {
            StreamWriter sw = null;
            bool pudoGuardar = false;
            string barra = "<------------------------------------------------------------------------------------------------------------------------->\n";

           if(File.Exists(pathSalida))
            {
                if (Path.GetExtension(pathSalida) is ".txt")
                {
                    using (sw = new StreamWriter(pathSalida, true, Encoding.UTF8))
                    {
                        sw.WriteLine(barra + "DETALLE: " + datosAGuardar);
                        pudoGuardar = true;
                    }
                }
                else
                {
                    throw new ArchivosException($"El archivo {pathSalida} no es del tipo .txt");
                }
            }
            else
            {
                using (sw = new StreamWriter(pathSalida))
                {
                    sw.WriteLine(barra + "DETALLE: " + datosAGuardar);
                    pudoGuardar = true;
                }
            }

            

            return pudoGuardar;
        }

        /// <summary>
        /// Método que extiende la clase string y lee datos de un archivo de texto.
        /// 
        /// Verificando que:
        /// Si el archivo existe -> Lo lee.
        /// Si no existe el archivo -> Lanza excepción.
        /// 
        /// Si el directorio existe 
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <returns></returns>
        public static string Leer(this string pathArchivo)
        {
            StreamReader sr = null;
            string contenidoLeido = string.Empty;

            if(File.Exists(pathArchivo))
            {
                if (Path.GetExtension(pathArchivo) is ".txt")
                {
                    using (sr = new StreamReader(pathArchivo))
                    {
                        contenidoLeido = sr.ReadToEnd();
                    }
                }
                else
                {
                    throw new ArchivosException($"El archivo {pathArchivo} no es del tipo .txt");
                }
            }
            else
            {
                throw new ArchivosException($"El archivo '{pathArchivo}' no existe.\nPorque todavía no ocurrió ningún error en el programa.");

            }

            return contenidoLeido;
        }
        #endregion

    }
}
