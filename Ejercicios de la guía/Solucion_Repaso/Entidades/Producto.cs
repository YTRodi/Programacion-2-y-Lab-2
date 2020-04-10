using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        //ctrl + k,d ordena el codigo.

        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string paramMarca, string paramCodigo, float paramPrecio)
        {
            this.marca = paramMarca;
            this.codigoDeBarra = paramCodigo;
            this.precio = paramPrecio;
        }

        #region Métodos
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + p.marca);//console.writeline (parecido).
            sb.AppendLine("Precio: " + p.precio);
            sb.AppendLine("Precio: " + p.precio);
            return sb.ToString();
        }
        #endregion


        #region Conversiones
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        #endregion


        #region Operaciones
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator ==(Producto p, string paramMarca)
        {
            return (p.marca == paramMarca);
        }

        public static bool operator !=(Producto p, string paramMarca)
        {
            return !(p.marca == paramMarca);
        }
        #endregion
    }
}
