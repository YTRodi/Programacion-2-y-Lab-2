using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        private string lastPath;
        #region Métodos
        public bool Guardar(string ruta, string objeto)
        {
            bool pudoGuardar = false;
            //ruta = lastPath;
            if (this.ValidarArchivo(ruta,true) && !(objeto is null))
            {
                StreamWriter sw = new StreamWriter(ruta);
                sw.WriteLine(objeto);
                sw.Close();
                pudoGuardar = true;
            }
            else
            {
                this.GuardarComo(ruta, objeto);
            }
            return pudoGuardar;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            return this.Guardar(ruta, objeto);
            //bool pudoGuardar = false;
            //ruta = lastPath;

            //if (this.ValidarArchivo(ruta, true) && !(objeto is null))
            //{
            //    StreamWriter sw = new StreamWriter(ruta);
            //    sw.WriteLine(objeto);
            //    sw.Close();
                
            //    pudoGuardar = true;
            //}
            //return pudoGuardar;
        }

        /// <summary>
        /// Lee un archivo de texto, lo cierra y retorna el contenido del .txt
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public string Leer(string ruta)
        {
            string contenidoLeido = string.Empty;
            if(this.ValidarArchivo(ruta,true))
            {
                StreamReader sr = new StreamReader(ruta);
                contenidoLeido = sr.ReadToEnd();
                lastPath = ruta;
                sr.Close();
            }
            return contenidoLeido;
        }
        #endregion

        #region Override
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool extensionCorrecta = false;

            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) is ".txt")
                        extensionCorrecta = true;
                }
                else
                    throw new ArchivoIncorrectoException("El archivo no es un .txt");
            }
            catch (FileNotFoundException)
            {
                //Manejo la excepción, si no existe el archivo pero 
                //tiene la extensión correcta, el método retorna true.
                if (Path.GetExtension(ruta) is ".txt")
                    extensionCorrecta = true;
                else
                    throw new ArchivoIncorrectoException("El archivo no es un .txt");
            }
            catch (ArchivoIncorrectoException aE)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", aE);
            }

            return extensionCorrecta;
        }
        #endregion

    }
}
