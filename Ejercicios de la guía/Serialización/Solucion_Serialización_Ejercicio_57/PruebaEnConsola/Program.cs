using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p01 = new Persona("Nacho", "Rodi");
            Console.WriteLine("Datos de la persona a serializar: (p01)\n" + p01);
            Persona.Guardar(p01);//Serializo

            Persona personaLeida = new Persona();
            personaLeida = Persona.Leer();//Deserializo
            Console.WriteLine("Datos de la persona deserializada: (personaLeida)\n" + personaLeida);
            //C:\Users\YAGO\Desktop\Solucion_Serializacion_ejercicio57\PruebaEnConsola\bin\Debug

            Console.ReadKey();
        }
    }
}
