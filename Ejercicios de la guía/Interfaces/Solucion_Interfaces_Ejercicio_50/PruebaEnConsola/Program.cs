using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<object, object> guardarTexto = new GuardarTexto<object, object>();
            Serializar<object, object> serializar = new Serializar<object, object>();

            Console.WriteLine(guardarTexto.Leer());
            Console.WriteLine(guardarTexto.Guardar("cualquier cosa toma"));

            Console.WriteLine(serializar.Leer());
            Console.WriteLine(serializar.Guardar("cualquier cosa toma"));


            //                  EJEMPLO: como usar Convert.ChangeType

            //Double d = -2.345;
            //int i = (int)Convert.ChangeType(d, TypeCode.Int32);

            //Console.WriteLine("The Double {0} when converted to an Int32 is {1}", d, i);

            Console.ReadKey();
        }
    }
}
