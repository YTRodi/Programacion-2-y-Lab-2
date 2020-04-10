using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private int ubicacionEstante;//ID
        private Producto[] arrayProductos;

        #region Constructores
        private Estante(int capacidad)
        {
            this.arrayProductos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion


        #region Métodos
        public Producto[] GetProductos()
        {
            return this.arrayProductos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ubicacion: " + e.ubicacionEstante);
            sb.AppendLine("Productos: ");

            foreach(Producto auxProducto in e.GetProductos())//o e.arrayProductos;
            {
                if(!(auxProducto is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(auxProducto));
                }
            }
            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Estante e, Producto p)
        {
            return e.arrayProductos.Contains(p);//retorna true si lo encuentra y false si no.
            //bool retorno = false;
            //foreach (Producto auxProducto in e.GetProductos())//recorro para ver si existen.
            //{
            //    if (!(auxProducto is null) && auxProducto == p)
            //    {
            //        retorno = true;
            //    }
            //}
            //return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        //+
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            
            if(e != p)//si el producto no se encuentra en el estante.
            {
                //Producto[] auxProductos = e.GetProductos();

                //for (int i = 0; i < auxProductos.Length; i++)
                for (int i = 0; i < e.arrayProductos.Length; i++)
                {
                    if (e.arrayProductos[i] is null)// Si es null es que me queda espacio.
                    {
                        e.arrayProductos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)//Si el producto se encuentra en el estante
            {
                //Producto[] auxProductos = e.GetProductos();

                //for (int i = 0; i < auxProductos.Length; i++)//recorro los productos.
                for (int i = 0; i < e.arrayProductos.Length; i++)//recorro los productos.
                {
                    if (e.arrayProductos[i] == p)//si el producto se encuentra en el listado de productos
                    {
                        e.arrayProductos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }
        #endregion

    }
}
