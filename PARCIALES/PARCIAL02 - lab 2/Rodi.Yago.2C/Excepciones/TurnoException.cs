using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TurnoException : Exception
    {
        #region Constructores
        /// <summary>
        /// Constructor que llama a la base y inicializa el mensaje.
        /// </summary>
        /// <param name="msg">Paso por constructor, el mensaje personalizado que creé antes.</param>
        public TurnoException(string msg) : base(msg)
        {

        }

        /// <summary>
        /// Constructor que llama a la base, inicializa el mensaje y la innerException.
        /// </summary>
        /// <param name="msg">Paso por constructor, el mensaje personalizado que creé antes.</param>
        /// <param name="innerException">Tambien le paso parametrizado el objeto Exception.</param>
        public TurnoException(string msg, Exception innerException) : base(msg, innerException)
        {

        }
        #endregion
    }
}
