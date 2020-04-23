using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto1 = new Automovil(10, 4, 5, VehiculoTerrestre.Colores.Negro, 6);
            Camion camion1 = new Camion(2500, 18, 2, VehiculoTerrestre.Colores.Blanco, 6);
            Moto moto1 = new Moto(125, 2, 0, VehiculoTerrestre.Colores.Rojo, 6);

            Console.WriteLine(auto1.Mostrar());
            Console.WriteLine(camion1.Mostrar());
            Console.WriteLine(moto1.Mostrar());
            Console.ReadKey();
        }
    }
}
