using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        #region Enumerados
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        #endregion

        #region Atributos
        private string autor;
        private TipoComic tipoComic;
        #endregion

        #region Constructores
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("<-----Datos del cómic----->"));
            sb.AppendLine(string.Format("Autor: {0}", this.autor));
            sb.AppendLine(string.Format("Tipo comic: {0}", this.tipoComic));
            return sb.ToString();
        }
        #endregion
    }
}
