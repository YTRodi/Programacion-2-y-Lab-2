using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoIncorrectoException : Exception
    {
        #region Constructores
        public ArchivoIncorrectoException(string mensaje)
            : this(mensaje, null)
        {
        }
        public ArchivoIncorrectoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
        #endregion
    }
}
