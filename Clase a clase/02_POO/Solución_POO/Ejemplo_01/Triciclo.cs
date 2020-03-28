using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejemplo_01
{
    public class Triciclo //ctrl + r r para cambiar el nombre
    {
        public int color;//USO THIS.LALALA
        public static string CantidadRuedas;//atributo de clase. pertenece a la clase //USO NOMBRECLASE.LALALA

        public int GetColor()
        {
            return this.color;
        }

        public string GetCantidadRuedas()//metodo de clase
        {
            return Triciclo.CantidadRuedas;
        }

        public void SetCantidadRuedas(string aux)//metodo de clase
        {
            Triciclo.CantidadRuedas = aux;
        }

        //public void SetCantidadRuedas(string aux)
        //{
        //    Triciclo.CantidadRuedas = aux;
        //}
    }
}
