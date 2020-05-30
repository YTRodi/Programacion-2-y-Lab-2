using CentralitaHerencia;
using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Yago Center");

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial("Quilmes", Provincial.Franja.Franja_3, 12, "CABA");

            c.RutaDeArchivo = Directory.GetCurrentDirectory() + @"\LogLlamadas.txt";
            //Se guarda en Solucion_ArchivosDeTexto_Ejercicio_55/PruebaConsola/bin/Debug
            try
            {
                c += l1;
                c += l2;
                c += l3;
                c += l4;
            }
            //catch (FallaLogException fLog)
            //{
            //    Console.WriteLine("No sé pudo guardar la llamada");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(c.Leer());


            Console.ReadKey();
        }
    }
}
