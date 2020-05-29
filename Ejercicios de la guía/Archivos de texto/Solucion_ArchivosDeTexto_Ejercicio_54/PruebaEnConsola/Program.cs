using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;
using Entidades.Excepciones;
using IO;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathDondeGuardo = $@"C:\Users\YAGO\Desktop\archivoError.txt";
            string msgDeLaExcepcion = string.Empty;

            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.OtroMetodoInstancia();//provoco la excepción.
            }
            catch (MiExcepcion miEx)
            {
                msgDeLaExcepcion = $"Horario y fecha: {DateTime.Now}\n" +
                    $"Ubicación del error: {miEx.Message}\n" +
                    $"Caso del error: {miEx.InnerException.Message}";

                if (ArchivoTexto.Guardar(pathDondeGuardo, msgDeLaExcepcion))
                    Console.WriteLine("Excepción guardada con éxito.");
                else
                    Console.WriteLine("No sé pudo guardar la Excepción.");
            }


            try
            {
                Thread.Sleep(1500);
                Console.WriteLine("Leyendo la excepción...");
                Thread.Sleep(1500);
                Console.WriteLine(ArchivoTexto.Leer(pathDondeGuardo));
            }
            catch (FileNotFoundException fNotFound)
            {
                Console.WriteLine(fNotFound.Message + $"\nPath donde buscó: {Path.GetDirectoryName(pathDondeGuardo)}");
            }
            Console.ReadKey();
        }
    }
}
