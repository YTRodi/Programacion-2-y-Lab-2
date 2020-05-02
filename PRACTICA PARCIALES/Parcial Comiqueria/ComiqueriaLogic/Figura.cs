using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        #region Atributos
        private double altura;
        #endregion

        #region Contructores
        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        public Figura(int stock, double precio, double altura) : this("Figura " + altura + "cm", stock, precio, altura)
        {
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("<-----Datos de la figura----->"));
            sb.AppendLine(string.Format("Altura: {0}", this.altura));
            return sb.ToString();
        }
        #endregion

    }
}
