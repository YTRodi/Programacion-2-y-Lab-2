using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }

        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int cantidadPasajeros;


        private int pesoCarga;//camion

        private short cilindrada;//cilindrada 

        #region Constructores
        public VehiculoTerrestre(short pCantidadRuedas, short pCantidadPuertas, Colores pColor, short pCantidadMarchas) //int pCantidadPasajeros)
        {
            this.cantidadRuedas = pCantidadRuedas;
            this.cantidadPuertas = pCantidadPuertas;
            this.color = pColor;
            this.cantidadMarchas = pCantidadMarchas;
        }
        #endregion

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nCantidad de ruedas: " + this.cantidadRuedas);
            sb.AppendLine("Cantidad de Puertas: " + this.cantidadPuertas);
            sb.AppendLine("Color: " + this.color);
            sb.AppendLine("Cantidad de marchas: " + this.cantidadMarchas);
            return sb.ToString();
        }


    }
}
