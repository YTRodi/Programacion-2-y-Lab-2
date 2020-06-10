using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Plancha : Electrodomestico
    {
        #region Atributos
        ETipo tipoElec;
        #endregion

        #region Properties
        public override float CostoFinalElectrodomestico
        {
            get { return this.CalcularCostoConIva(); }
            
        }
        public override ETipo TipoElectrodomestico
        {
            get { return ETipo.MantenimientoCasa; }
        }
        #endregion

        #region Constructores
        public Plancha()//no estoy seguro si dejarlo para seializar...
        {
        }
        public Plancha(string modelo, string descripcion, string funcionPrincipal, float precioNeto, EColor color, bool garantia)
            : base(modelo, descripcion, funcionPrincipal, precioNeto, color, garantia)
        {
            this.tipoElec = ETipo.MantenimientoCasa;
        }

        #endregion

        #region Métodos
        public float CalcularCostoConIva()
        {
            //return base.Precio * base.IVA;
            return this.PrecioNeto * base.IVA;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return (obj is Plancha);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Producto: Plancha");
            sb.AppendLine($"Tipo: {this.TipoElectrodomestico}");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Precio final (con IVA): ${this.CostoFinalElectrodomestico + this.PrecioNeto}");

            return sb.ToString();
        }
        #endregion

    }
}
