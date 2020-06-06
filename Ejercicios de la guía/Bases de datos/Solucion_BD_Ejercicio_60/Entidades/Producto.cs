using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public enum EColores { Dark, Green, Red }

        #region Attributes
        private string nombreProducto;
        private string numeroProducto;
        private EColores colorProducto;
        #endregion

        #region Properties
        public string nombreP
        {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value; }
        }
        public string numeroP
        {
            get { return this.numeroProducto; }
            set { this.numeroProducto = value; }
        }
        public EColores colorP
        {
            get { return this.colorProducto; }
            set { this.colorProducto = value; }
        }
        #endregion

        public Producto(string nombreProducto, string numeroProducto, EColores colorProducto)
        {
            this.nombreP = nombreProducto;
            this.numeroP = numeroProducto;
            this.colorP = colorProducto;
        }

    }
}
