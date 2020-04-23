using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        protected int pesoCarga;

        public Camion(int pPesoCarga, short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCantidadMarchas)
            : base(pCantidadRuedas, pCantidadPuertas, pColor, pCantidadMarchas)
        {
            this.pesoCarga = pPesoCarga;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************");
            sb.AppendLine("Datos clase Vehiculo: " + base.Mostrar());
            sb.AppendLine("Datos propios del camión:");
            sb.AppendLine("Peso de carga: " + this.pesoCarga);
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
        //private int pesoCarga;

        //#region Constructores
        //public Camion(short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCantidadMarchas, int pPesoCarga)
        //{
        //    this.cantidadMarchas = pCantidadRuedas;
        //    this.cantidadPuertas = pCantidadPuertas;
        //    this.color = pColor;
        //    this.cantidadMarchas = pCantidadMarchas;
        //    this.pesoCarga = pPesoCarga;
        //}
        //#endregion
    }
}
