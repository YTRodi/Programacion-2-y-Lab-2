using CentralitaHerencia;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    class Program
    {
        //public static bool LlamadaAgregada(Centralita centralita, Llamada llamadita)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        centralita += llamadita;
        //        retorno = true;
        //    }
        //    catch (CentralitaException ce)
        //    {
        //        //retorno = false; //REDUNDANTE.
        //        //throw new CentralitaException("PEPE", "LALA", "LLAMADAAGREGADA",ce);
        //        Console.WriteLine(string.Format($"{ce.Message}\n" +
        //            $"CLASE: {ce.NombreClase}\n" +
        //            $"MÉTODO: {ce.NombreMetodo}",$"{ce}"));
        //    }
        //    return retorno;
        //}
        static void Main(string[] args)
        {
            // Mi central 
            Centralita c = new Centralita("Yago Center");

            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            Provincial l4_COPIA = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita. 
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 

            //c.Llamadas.Add(l1);
            //Console.WriteLine("1\n" + c.ToString());
            //Console.ReadKey();
            //Console.WriteLine("Presiona una tecla para continuar...");
            //Console.Clear();


            //c.Llamadas.Add(l2);
            //Console.WriteLine("2\n" + c.ToString());
            //Console.ReadKey();
            //Console.WriteLine("Presiona una tecla para continuar...");

            //Console.Clear();

            ////Console.WriteLine(c.Mostrar());

            //c.Llamadas.Add(l3);
            //Console.WriteLine("3\n" + c.ToString());
            //Console.ReadKey();
            //Console.WriteLine("Presiona una tecla para continuar...");
            //Console.Clear();


            //c.Llamadas.Add(l4);
            //Console.WriteLine("4\n" + c.ToString());
            //Console.ReadKey();
            //Console.WriteLine("Presiona una tecla para continuar...");
            //Console.Clear();

            //c += l1;
            //c += l2;
            //c += l3;
            c += l4;

            try
            {
                c += l4;
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine($"{ce.Message}\n" +
                    $"CLASE: {ce.NombreClase}\n" +
                    $"MÉTODO: {ce.NombreMetodo}");
            }
            finally
            {
                Console.WriteLine("SIEMPRE SE EJECUTA EL FINALLY");
            }

            //NO LAS TIENE QUE AGREGAR.
            //c.Llamadas.Add(l2);
            //Console.WriteLine(c.Mostrar());

            //c.Llamadas.Add(l3);
            //Console.WriteLine(c.Mostrar());

            //c.Llamadas.Add(l4);
            //Console.WriteLine(c.Mostrar());

            //c.OrdenarLlamadas();
            //Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
