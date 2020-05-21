using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        #region Constructores
        public EquipoFutbol(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }
        #endregion
    }
}
