using MétodoEscrituraWrapper;
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        #region Atributos
        private float tamanioMina;
        #endregion

        #region Properties
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.DarkGray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        #endregion

        #region Constructores
        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        #endregion

        #region Métodos
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura -= texto.Length * 0.1f;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Lapiz");
            sb.AppendLine($"Color de escritura: {((IAcciones)this).Color}");
            sb.AppendLine($"Nivel de tinta: {((IAcciones)this).UnidadesDeEscritura}%");
            return sb.ToString();
        }
        #endregion
    }
}
