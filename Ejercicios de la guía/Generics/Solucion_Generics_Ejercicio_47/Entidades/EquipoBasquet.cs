using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasquet : Equipo
    {
        #region Constructores
        public EquipoBasquet(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }
        #endregion
    }
}
