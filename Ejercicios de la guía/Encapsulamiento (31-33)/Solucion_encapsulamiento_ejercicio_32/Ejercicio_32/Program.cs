using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer con un while preguntando si desea agregar jugadores bla bla bla...
            Jugador j1 = new Jugador(12345678, "Camu", 15, 100);
            Jugador j2 = new Jugador(41448581, "Yago", 10, 150);

            Equipo equipito = new Equipo(5, "Boquita");

            if (equipito + j1)
            {
                Console.WriteLine("Jugador agregado con éxito");
            }
            else
            {
                Console.WriteLine("Jugador ya agregado");
            }

            if (equipito + j2)
            {
                Console.WriteLine("Jugador agregado con éxito");
            }
            else
            {
                Console.WriteLine("Jugador ya agregado");
            }

            if (equipito + j2)
            {
                Console.WriteLine("Jugador agregado con éxito");
            }
            else
            {
                Console.WriteLine("Jugador ya agregado");
            }



            Console.WriteLine(equipito.MostrarEquipo());


            //Console.WriteLine(j1.MostrarDatos());
            //Console.WriteLine(j2.MostrarDatos());

            //if(j1 == j2)
            //{
            //    Console.WriteLine("Son iguales, tienen el mismo dni");
            //}
            //else
            //{
            //    Console.WriteLine("Nope");
            //}

            Console.ReadKey();
        }
    }
}
