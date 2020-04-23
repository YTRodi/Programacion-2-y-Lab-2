using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        protected int cantidadPasajeros;
        public Automovil(int pCantidadPasajeros,short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCantidadMarchas) 
            : base(pCantidadRuedas,pCantidadPuertas,pColor,pCantidadMarchas)
        {
            this.cantidadPasajeros = pCantidadPasajeros;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************");
            sb.AppendLine("Datos clase Vehiculo: " + base.Mostrar());
            sb.AppendLine("Datos propios del auto:");
            sb.AppendLine("Cantidad de pasajeros: " + this.cantidadPasajeros);
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
        //private short cantidadMarchas;
        //private int cantidadPasajeros;

        //#region Constructores
        //public Automovil(short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCantidadMarchas, int pCantidadPasajeros)
        //{
        //    this.cantidadMarchas = pCantidadRuedas;
        //    this.cantidadPuertas = pCantidadPuertas;
        //    this.color = pColor;
        //    this.cantidadMarchas = pCantidadMarchas;
        //    this.cantidadPasajeros = pCantidadPasajeros;
        //}

    }
}
