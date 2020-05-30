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
            l1.RutaDeArchivo = Directory.GetCurrentDirectory() + @"\llamadasLocales.xml";
            l3.RutaDeArchivo = l1.RutaDeArchivo;
            l2.RutaDeArchivo = Directory.GetCurrentDirectory() + @"\llamadasProvinciales.xml";
            l4.RutaDeArchivo = l2.RutaDeArchivo;

            try
            {
                //Locales.
                c += l1;
                c += l3;
                if(l1.Guardar() && l3.Guardar())
                    Console.WriteLine("Se guardaron las llamadas Locales en llamadasLocales.xml");

                //Provinciales.
                c += l2;
                c += l4;
                if (l2.Guardar() && l4.Guardar())
                    Console.WriteLine("Se guardaron las llamadas Provinciales en llamadasProvinciales.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------llamadasLocales.xml--------------");
            Console.WriteLine(l1.Leer().ToString());
            Console.WriteLine(l3.Leer().ToString());

            Console.WriteLine("--------------llamadasProvinciales.xml--------------");
            Console.WriteLine(l2.Leer().ToString());
            Console.WriteLine(l4.Leer().ToString());
            //Console.WriteLine(c.Leer());


            Console.ReadKey();
        }
    }
}
