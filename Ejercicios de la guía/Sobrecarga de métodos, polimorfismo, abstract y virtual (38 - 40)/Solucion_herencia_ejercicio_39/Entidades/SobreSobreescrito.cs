using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SobreSobreescrito : Sobreescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }

    }
}
