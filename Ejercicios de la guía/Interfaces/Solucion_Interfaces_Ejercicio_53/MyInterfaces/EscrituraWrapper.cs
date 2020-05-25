using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodoEscrituraWrapper
{
    public class EscrituraWrapper
    {
        #region Atributos
        public ConsoleColor color;
        public string texto;
        #endregion

        #region Métodos
        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }
        #endregion
    }
}
