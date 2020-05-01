using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        #region Atributos
        private const int MEDIDA = 330;
        private Tipo tipo;
        #endregion

        #region Constructores
        public Cerveza(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : this(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Métodos
        public override int ServirMedida()
        {
            int servi = 0;
            //if(base.Contenido <= Cerveza.MEDIDA)
            if (Cerveza.MEDIDA <= base.Contenido)
            {
                servi = Cerveza.MEDIDA;
                //servi = (int)(Cerveza.MEDIDA * 0.8);
            }

            servi = servi * 80 / 100;
            base.Contenido -= servi;
            //else
            //{
            //    servi = base.Contenido;
            //}
            return servi;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine("Medida de Cerveza: " + Cerveza.MEDIDA);
            sb.AppendLine("Tipo de envase: " + this.tipo);
            sb.AppendLine("<---------------------------------------->");
            return sb.ToString();
        }
        #endregion

        #region Conversiones
        public static implicit operator Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
            //DUDA
        }
        #endregion
    }
}
