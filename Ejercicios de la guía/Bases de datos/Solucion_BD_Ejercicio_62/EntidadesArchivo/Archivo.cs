using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class Archivo
    {
        //IO = input output;
        #region Métodos
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool retorno = false;

            if (validaExistencia)
            {
                if (File.Exists(ruta))
                    retorno = true;
                else
                    throw new FileNotFoundException(); 
            }
            return retorno;
        }
        #endregion
    }
}
