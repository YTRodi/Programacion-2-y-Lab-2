using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Excepciones;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.OtroMetodoInstancia();//provoco la excepción.
            }
            //catch (MiExcepcion miEx)//se produce una excepción del tipo MiExcepcion
            //{
            //    Console.WriteLine(miEx.Message);
            //    //Console.WriteLine(miEx.InnerException); //SI DEJO ESTO MUESTRA TODO EL PATH DE LOS ERRORES.
            //    Console.WriteLine(miEx.InnerException.Message);


            //    Exception ex = miEx.InnerException;
            //    Console.WriteLine($"MENSAJE: {ex.Message} EN: {ex.Source}");//Muestro solo la InnerException.



            //    //SI TENEMOS MUCHAS INNEREXCEPTIONS
            //    //determinamos si pertenecen a la misma instancia
            //    //verifico que no sea null en esta caso...
            //    //if (!Object.ReferenceEquals(miEx,null))
            //    //{
            //    //    Exception ex = miEx.InnerException;//guardo la innerException
            //    //    do
            //    //    {
            //    //        Console.WriteLine(ex.Message);
            //    //        ex = ex.InnerException;

            //    //    } while (!Object.ReferenceEquals(ex,null));//Hasta que no se llamen a todos los Inner, no termina el bucle.
            //    //}
            //}
            Console.ReadKey();
        }
    }
}
