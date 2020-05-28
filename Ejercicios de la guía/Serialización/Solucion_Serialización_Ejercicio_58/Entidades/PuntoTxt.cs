using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        #region Métodos
        public bool Guardar(string ruta, string objeto)
        {
            //if (this.ValidarArchivo(ruta, true) && !(objeto is null))
            //{
            //    return true;
            //}
            return true;

        }

        public bool GuardarComo(string ruta, string objeto)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
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
            catch (ArchivoIncorrectoException aE)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", aE);
            }

            return extensionCorrecta;
        }
        #endregion

    }
}
