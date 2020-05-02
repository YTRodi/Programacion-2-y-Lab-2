using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Atributos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        #endregion

        #region Properties
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        #endregion

        #region Constructores
        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto product, int cantidad)//sólo debe ser accesible desde el mismo ensamblado
        {
            this.producto = product;
            this.Vender(cantidad);
        }
        #endregion

        #region Métodos
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioUnidadXCantidad = precioUnidad * cantidad;
            double ivaPorcentaje = precioUnidadXCantidad * Venta.porcentajeIva / 100;
            double precioFinal = precioUnidadXCantidad + ivaPorcentaje;

            return precioFinal;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Fecha: {0} -- Producto: {1} -- Precio Final: ${2}", this.Fecha, this.producto.Descripcion, this.precioFinal);

            return sb.ToString();
        }
        #endregion


    }
}
