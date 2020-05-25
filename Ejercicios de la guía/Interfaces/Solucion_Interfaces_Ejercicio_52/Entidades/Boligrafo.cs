using MétodoEscrituraWrapper;
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        #region Atributos
        private ConsoleColor colorTinta;
        private float tinta;
        EscrituraWrapper eWrapper;
        #endregion

        #region Properties
        public ConsoleColor Color 
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura 
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        #endregion

        #region Constructores
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }
        #endregion

        #region Métodos
        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= texto.Length * 0.3f;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            bool recargo = false;
            if (unidades == 100)
                this.tinta = 100;
            else
                this.tinta += unidades;

            return recargo;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Boligrafo");
            sb.AppendLine($"Color de escritura: {this.Color}");
            sb.AppendLine($"Nivel de tinta: {this.UnidadesDeEscritura}%");
            return sb.ToString();
        }
        #endregion
    }
}
