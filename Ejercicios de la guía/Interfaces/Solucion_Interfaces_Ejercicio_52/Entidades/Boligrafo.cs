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
    class Boligrafo : IAcciones
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
            
        }

        public bool Recargar(int unidades)
        {
            
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
