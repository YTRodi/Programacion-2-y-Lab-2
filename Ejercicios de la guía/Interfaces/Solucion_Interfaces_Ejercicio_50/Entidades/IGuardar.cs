using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IGuardar<T,V>
    {
        #region Métodos
        bool Guardar(T obj);
        V Leer();
        #endregion
    }
}
