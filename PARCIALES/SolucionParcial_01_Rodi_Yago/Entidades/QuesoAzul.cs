using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class QuesoAzul : Ingrediente
    {
        #region Enumerado
        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }
        #endregion

        #region Atributos
        private Procedencia procedencia;
        #endregion

        #region Properties
        public override string Proceso
        {
            get
            {
                return "desgranar";
            }
        }
        public override string UnidadDeMedida
        {
            get
            {
                return "gramos";
            }
        }
        #endregion

        #region Constructores
        public QuesoAzul(string descripcion, int cantidad) : base(descripcion, cantidad)
        {
        }

        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia) : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }
        #endregion

        #region Métodos
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}", base.Informacion()));
            sb.AppendLine(string.Format("Procedente de: {0}", this.procedencia));
            return sb.ToString();
        }
        #endregion
    }
}
