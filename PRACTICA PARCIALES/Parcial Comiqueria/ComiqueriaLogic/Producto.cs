using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Atributos
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Constructores
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();//intancio el código.
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        #endregion

        #region Properties
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0 )
                {
                    this.stock = value;
                }
            }
        }
        #endregion

        #region Conversiones
        public static explicit operator Guid(Producto product)
        {
            return (Guid)product.codigo;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("<-----Datos del producto----->"));
            sb.AppendLine(string.Format("Descripción: {0}", this.Descripcion));
            sb.AppendLine(string.Format("Código: {0}", this.codigo));
            sb.AppendLine(string.Format("Precio: ${0}", this.Precio));
            sb.Append(string.Format("Stock: {0}", this.Stock));
            return sb.ToString();
        }
        #endregion
    }
}
