using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGuardar<T>
    {
        #region Properties
        string RutaDeArchivo { get; set; }
        #endregion

        #region Métodos
        bool Guardar();
        T Leer();
        #endregion
    }
}
