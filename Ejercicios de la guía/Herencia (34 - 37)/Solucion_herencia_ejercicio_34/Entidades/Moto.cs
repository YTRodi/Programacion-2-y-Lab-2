using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        protected short cilindrada;

        public Moto(short pCilindrada, short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCantidadMarchas)
            : base(pCantidadRuedas, pCantidadPuertas, pColor, pCantidadMarchas)
        {
            this.cilindrada = pCilindrada;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************");
            sb.AppendLine("Datos clase Vehiculo: " + base.Mostrar());
            sb.AppendLine("Datos propios de la moto:");
            sb.AppendLine("Cilindrada: " + this.cilindrada);
            sb.AppendLine("**************************");

            return sb.ToString();
        }
        //public enum Colores
        //{
        //    Rojo, Blanco, Azul, Gris, Negro
        //}

        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private Colores color;
        //private short cilindrada;

        //#region Constructores
        //public Moto(short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCilindrada)
        //{
        //    this.cantidadRuedas = pCantidadRuedas;
        //    this.cantidadPuertas = pCantidadPuertas;
        //    this.color = pColor;
        //    this.cilindrada = pCilindrada;
        //}
        //#endregion
    }
}
