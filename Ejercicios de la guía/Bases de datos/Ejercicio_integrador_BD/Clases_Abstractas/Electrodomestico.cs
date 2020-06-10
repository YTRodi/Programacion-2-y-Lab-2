using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesAbstractas
{
    //ARMAR LAS TABLAS: ELECTRODOMESTICOS, VENTAS y CENTRALES
    public class Electrodomestico //TAMBIÉN SERIALIZAR EN XML...
    {
        #region Enumerado
        //https://es.wikipedia.org/wiki/Electrodom%C3%A9stico
        public enum ETipo { MantenimientoCasa, Alimentos, Higiene, Todos}
        public enum EColor { Blanco, Amarillo, Rojo, Negro }
        #endregion

        #region Atributos
        string modelo;
        string descripción;
        string funcionPrincipal;
        float precioNeto;
        EColor color;
        bool garantia; // o string...
        float iva = 0.21f;
        #endregion

        #region Properties
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        public string Descripcion
        {
            get { return this.descripción; }
            set { this.descripción = value; }
        }
        public string FuncPrincipal
        {
            get { return this.funcionPrincipal; }
            set { this.funcionPrincipal = value; }
        }
        public float PrecioNeto
        {
            get { return this.precioNeto; }
            set { this.precioNeto = value; }
        }
        public EColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public bool Garantia
        {
            get { return this.garantia; }
            set { this.garantia = value; }
        }
        protected float IVA
        {
            get { return this.iva; }
        }
        public virtual float CostoFinalElectrodomestico { get; } //para serializar en XML
        public virtual ETipo TipoElectrodomestico { get; } //para serializar en XML
        #endregion

        #region Constructores
        public Electrodomestico()//para serializar en XML
        {
        }

        public Electrodomestico(string modelo, string descripcion, string funcionPrincipal, float precioNeto)
        {
            this.Modelo = modelo;
            this.Descripcion = descripcion;
            this.FuncPrincipal = funcionPrincipal;
            this.PrecioNeto = precioNeto;
            this.Color = EColor.Blanco;
            //this.Garantia = true;
        }
        public Electrodomestico(string modelo, string descripcion, string funcionPrincipal, float precioNeto, EColor color)
            : this(modelo, descripcion, funcionPrincipal, precioNeto)
        {
            this.Color = color;
        }
        public Electrodomestico(string modelo, string descripcion, string funcionPrincipal, float precioNeto, EColor color, bool garantia)
            : this(modelo, descripcion, funcionPrincipal, precioNeto, color)
        {
            this.Garantia = garantia;
        }
        #endregion

        #region Métodos
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"Descripción: {this.Descripcion}");
            sb.AppendLine($"Función principal: {this.FuncPrincipal}");
            sb.AppendLine($"Color: {this.Color}");

            if(this.Garantia)
                sb.AppendLine($"Posee garantia: SI");
            else
                sb.AppendLine($"Posee garantia: NO");
            sb.Append($"Precio Neto: ${this.PrecioNeto}");

            return sb.ToString();
        }
        #endregion

        #region Conversiones

        #endregion

        #region Operaciones
        public static bool operator ==(Electrodomestico elec01, Electrodomestico elec02)
        {
            bool sonIguales = false;
            if (elec01.Equals(elec02))
                sonIguales = true;
            return sonIguales;
        }

        public static bool operator !=(Electrodomestico elec01, Electrodomestico elec02)
        {
            return !(elec01 == elec02);
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

    }
}
