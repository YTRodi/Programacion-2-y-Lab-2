using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T, U>
        where T : Documento
        where U : Documento, new()//debe tener un constructor por defecto sin argumentos (SI o SI).
    {
        #region Atributos
        private List<T> egresos;//facturas
        private List<U> ingresos;//recibos
        #endregion

        #region Constructores
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        #endregion

        #region Operaciones
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad, T egreso)
        {
            if (!(contabilidad is null) && !(egreso is null))
            {
                contabilidad.egresos.Add(egreso);
            }
            return contabilidad;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (!(contabilidad is null) && !(ingreso is null))
            {
                contabilidad.ingresos.Add(ingreso);
            }
            return contabilidad;
        }
        #endregion
    }
}
