using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1(10, "Yaggi's");
            Competencia compe1 = new Competencia(15, 3);

            if(compe1 + auto1)
            {
                Console.WriteLine("auto agregado con exito");
                Console.WriteLine(compe1.MostrarDatos());
            }



            Console.ReadKey();
        }
    }
}
