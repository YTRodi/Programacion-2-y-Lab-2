using CentralitaHerencia;
using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona d01 = new Persona() { nombre = "Camu", apellido = "Roy", edad = 21, sexo = 'f' };
            Persona d02 = new Persona() { nombre = "Yago", apellido = "Rodi", edad = 21, sexo = 'm' };
            Persona d03 = new Persona() { nombre = "Maggie", apellido = "Roy/Rodi", edad = 3, sexo = 'f' };

            Lista miLista = new Lista();
            miLista.Items.Add(d01);
            miLista.Items.Add(d02);
            miLista.Items.Add(d03);

            string path = Directory.GetCurrentDirectory() + @"\lista.xml";
            try
            {
                //Guardar
                using (XmlTextWriter xmlTW = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(Lista));
                    xmlSer.Serialize(xmlTW, miLista);
                }

                Console.WriteLine("Serializado con éxito");
                Console.WriteLine("Cargando datos del archivo...");
                Console.Beep();
                Thread.Sleep(1500);

                //Leer
                using (XmlTextReader xmlRD = new XmlTextReader(path))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(Lista));
                    miLista = (Lista)xmlSer.Deserialize(xmlRD);
                }

                Console.WriteLine(miLista.MostrarDatosLista());
                Console.Beep();
                Console.Beep(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
