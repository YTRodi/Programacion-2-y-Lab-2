using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        #region Atributos
        private const int MEDIDA = 400;
        #endregion

        #region Constructores
        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
        }
        #endregion

        #region Métodos
        protected int ServirMedida(int medida)
        {
            int servi = default(int);

            if (medida <= base.Contenido)
            {
                servi = Agua.MEDIDA;
            }
            else
            {
                servi = base.Contenido;
            }
            base.Contenido -= servi;

            return servi;
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }


        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine("Medida de agua: " + Agua.MEDIDA);
            return sb.ToString();
        }
        #endregion


    }
}
