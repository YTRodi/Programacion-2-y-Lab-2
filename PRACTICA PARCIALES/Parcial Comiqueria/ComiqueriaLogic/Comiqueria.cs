using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Atributos
        private List<Producto> listaProductos;
        private List<Venta> listaVentas;
        #endregion

        #region Properties
        public Producto this[Guid codigo]
        {
            get
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if((Guid)this.listaProductos[i] == codigo)
                    {
                        return this.listaProductos[i];
                    }
                }
                return null;
            }
        }
        #endregion

        #region Constructores
        public Comiqueria()
        {
            listaProductos = new List<Producto>();
            listaVentas = new List<Venta>();
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Comiqueria comiqueria, Producto product)
        {
            bool sonIguales = false;

            foreach (Producto item in comiqueria.listaProductos)
            {
                if (item.Descripcion == product.Descripcion)
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto product)
        {
            return !(comiqueria == product);
        }
        #endregion

        #region Operaciones
        public static Comiqueria operator +(Comiqueria comiqueria, Producto product)
        {
            if(comiqueria != product)
            {
                comiqueria.listaProductos.Add(product);
            }
            return comiqueria;
        }
        #endregion

        #region Métodos
        public void Vender(Producto product)
        {
            this.Vender(product,1);
        }
        public void Vender(Producto product, int cantidad)
        {
            this.listaVentas.Add(new Venta(product, cantidad));
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();

            //Primero ordeno la lista de ventas. + reciente a la más antigua.
            this.listaVentas.OrderByDescending(listitaVentas => listitaVentas.Fecha).ToList();

            foreach (Venta item in listaVentas)
            {
                sb.AppendLine(item.ObtenerDescripcionBreve());
            }
            return sb.ToString();
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            //creo una variable del mismo tipo que tengo que retornar
            Dictionary<Guid, string> retornoDiccionario = new Dictionary<Guid, string>();

            foreach (Producto item in this.listaProductos)
            {
                retornoDiccionario.Add((Guid)item, item.Descripcion);
            }
            return retornoDiccionario;
        }












        public int OrdenarListaVentas(Venta v1, Venta v2)
        {
            int retorno = 0;

            if(v1.Fecha > v2.Fecha)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }

        #endregion


    }
}
