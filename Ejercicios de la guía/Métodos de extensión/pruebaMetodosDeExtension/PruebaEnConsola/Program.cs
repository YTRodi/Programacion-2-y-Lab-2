using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//tengo que traer el namespace 
using Entidades;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string unTexto = "   Hola mundo   ";
            string otroTexto = null;

            //unTexto = unTexto.Trim();//borra los caracteres del inicio y del fin de la cadena
            unTexto = unTexto.SafeTrim();//borra los caracteres del inicio y del fin de la cadena


            Console.WriteLine(unTexto);



            otroTexto = otroTexto.SafeTrim()








            //if(!string.IsNullOrEmpty(otroTexto))
            //{
            //    //true si el string que pasamos es null o no contiene nada.
            //    otroTexto = otroTexto.Trim();
            //}

            //Console.WriteLine(otroTexto);



            Console.ReadKey();
        }
    }
}
