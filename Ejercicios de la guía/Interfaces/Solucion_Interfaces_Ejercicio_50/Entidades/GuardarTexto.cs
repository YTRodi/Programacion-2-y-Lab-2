using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    {
        #region Métodos Implementados
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leído(GuardarTexto.cs)", TypeCode.Object);
        }
        #endregion
    }
}
