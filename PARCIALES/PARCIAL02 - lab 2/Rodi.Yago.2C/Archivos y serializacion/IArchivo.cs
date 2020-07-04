using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_y_serializacion
{
    public interface IArchivo<T>
    {
        #region Métodos
        /// <summary>
        /// Método sin implementación que tendrá como propósito
        /// guardar datos.
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar(string pathArchivo, T datos);

        /// <summary>
        /// Método sin implementación que tendrá como propósito
        /// leer datos.
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Leer(string pathArchivo, out T datos);
        #endregion
    }
}
