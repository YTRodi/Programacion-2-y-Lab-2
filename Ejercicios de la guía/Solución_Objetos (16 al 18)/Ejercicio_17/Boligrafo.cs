using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ns_Boligrafo
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        /// <summary>
        /// Constructor modificado.
        /// Setea los campos: color y tinta por parametro.
        /// </summary>
        /// <param name="paramColor"></param>
        /// <param name="paramTinta"></param>
        public Boligrafo(short paramTinta, ConsoleColor paramColor)
        {
            SetTinta(paramTinta);
            this.color = paramColor;
        }


        /// <summary>
        /// Retorna el valor del color.
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Retorna el valor de la tinta.
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Pinta.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns>True = se pudo pintar || False = No se pudo pintar</returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = string.Empty;
            bool retornoBool = false;

            if(this.tinta>=gasto)
            {
                for(int i=0;i<gasto;i++)
                {
                    dibujo += "*";
                    //Console.WriteLine("*"); //No usar console.writeline por regla de negocio.
                }
                retornoBool = true;
                SetTinta((short)(tinta - gasto));
                //Console.ForegroundColor = GetColor();
            }
            return retornoBool;
        }



        /// <summary>
        /// Valida el nivel de tinta.
        /// </summary>
        /// <param name="paramTinta"></param>
        private void SetTinta(short paramTinta)
        {
            if(paramTinta >= 0 && paramTinta <= 100)
            {
                this.tinta = paramTinta;
            }
            else if (paramTinta < 0)
            {
                this.tinta -= paramTinta; // resto la tinta
            }
        }

        /// <summary>
        /// Coloca la tinta a su nivel máximo.
        /// </summary>
        public void Recargar()
        {
            SetTinta(100);
        }
    }
}
