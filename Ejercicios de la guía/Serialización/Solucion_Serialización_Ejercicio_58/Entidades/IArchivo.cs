using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    {
        #region Métodos
        bool Guardar(string ruta, T objeto);
        bool GuardarComo(string ruta, T objeto);
        T Leer(string ruta);
        #endregion
    }
}
