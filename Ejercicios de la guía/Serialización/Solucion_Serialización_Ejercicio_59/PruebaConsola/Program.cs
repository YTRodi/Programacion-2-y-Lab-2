using CentralitaHerencia;
using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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


            int countLocal = 1, countProvincial = 1;
            c.RutaDeArchivo = Directory.GetCurrentDirectory() + @"\LogLlamadas.txt";
            l1.RutaDeArchivo = Directory.GetCurrentDirectory() + $@"\Llamadas Locales\llamadaLocal{countLocal}.xml";
            l2.RutaDeArchivo = Directory.GetCurrentDirectory() + $@"\LLamadas Provinciales\llamadaProvincial{countProvincial}.xml";

            try
            {
                //Locales.
                c += l1;
                c += l3;
                if (l1.Guardar())
                {
                    Console.WriteLine($"Se guardó la llamada en: {l1.RutaDeArchivo}");
                    countLocal++;
                    l3.RutaDeArchivo = Directory.GetCurrentDirectory() + $@"\Llamadas Locales\llamadaLocal{countLocal}.xml";
                }
                if (l3.Guardar())
                {
                    Console.WriteLine($"Se guardó la llamada en: {l3.RutaDeArchivo}");
                    countLocal++;
                }


                //Provinciales.
                c += l2;
                c += l4;
                if (l2.Guardar())
                {
                    Console.WriteLine($"Se guardó la llamada en: {l2.RutaDeArchivo}");
                    countProvincial++;
                    l4.RutaDeArchivo = Directory.GetCurrentDirectory() + $@"\LLamadas Provinciales\llamadaProvincial{countProvincial}.xml";
                }
                if (l4.Guardar())
                {
                    Console.WriteLine($"Se guardó la llamada en: {l4.RutaDeArchivo}");
                    countProvincial++;
                }
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
