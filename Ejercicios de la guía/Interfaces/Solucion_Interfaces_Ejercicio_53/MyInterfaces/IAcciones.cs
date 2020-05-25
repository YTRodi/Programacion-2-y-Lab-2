using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MétodoEscrituraWrapper;

namespace MyInterfaces
{
    public interface IAcciones
    {
        #region Properties
        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }
        #endregion

        #region Métodos
        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);
        #endregion
    }
}
