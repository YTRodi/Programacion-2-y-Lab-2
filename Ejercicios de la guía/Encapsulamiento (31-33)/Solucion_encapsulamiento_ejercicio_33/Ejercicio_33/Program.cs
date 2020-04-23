using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro();

            miLibro[0] = "Pepe";
            miLibro[0] = "jujuy";//si vuelvo a asignar retora el set this.paginas[i] = value;
            miLibro[1] = "Dengue";

            Console.WriteLine(miLibro[1]);

            Console.ReadKey();
        }
    }
}
