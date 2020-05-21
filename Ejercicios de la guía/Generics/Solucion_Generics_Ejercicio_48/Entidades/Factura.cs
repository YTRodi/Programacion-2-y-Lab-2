using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura : Documento
    {
        #region Constructores
        public Factura(int numero) : base(numero)
        {
        }
        #endregion
    }
}
