using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Archivo
    {
        //IO = input output;
        #region Métodos
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia)
                return File.Exists(ruta);
            //if (File.Exists(ruta))
            //    return validaExistencia;
            else
                throw new FileNotFoundException();
        }
        #endregion
    }
}
