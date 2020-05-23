using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        #region Métodos Implementados
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leído(Serializar.cs)", TypeCode.Object);
        }
        #endregion
    }
}
