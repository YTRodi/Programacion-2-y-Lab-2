using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceXML
{
    interface IArchivo<T>
    {
        #region Métodos
        bool Guardar(string archivo, T datos);
        bool Leer(string archivo, out T datos);

        #endregion
    }
}
