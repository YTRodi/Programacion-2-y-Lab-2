using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sobreescrito aux1 = new Sobreescrito();// NO SE PUEDE INSTANCIAR UNA CLASE ABSTRACTA.
            SobreSobreescrito aux01 = new SobreSobreescrito();

            Console.WriteLine(aux01.MiPropiedad);
            Console.WriteLine(aux01.MiMetodo());


            Console.ReadKey();
        }
    }
}
