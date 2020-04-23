using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1(10, "Yaggi's", 1500);
            AutoF1 auto2 = new AutoF1(11, "Pedo's", 2000);
            AutoF1 auto3 = new AutoF1(12, "Philips", 3500);

            MotoCross moto1 = new MotoCross(15, "Maggie's", 125);
            MotoCross moto2 = new MotoCross(16, "Perlu's", 150);
            MotoCross moto3 = new MotoCross(17, "Fuyi's", 250);

            VehiculoDeCarrera vehiculo = new VehiculoDeCarrera(20, "Camu's");

            Competencia compeDeAutos = new Competencia(15, 2, Competencia.TipoCompetencia.F1);//del tipo AutoF1
            Competencia compeDeMotos = new Competencia(20, 2, Competencia.TipoCompetencia.MotoCross);

            //COMPETENCIA DE MOTOS, NO DEJA AGREGAR AUTOS.
            //if(compeDeMotos + auto1)
            //{
            //    Console.WriteLine("Auto agregado con éxito");
            //}
            //else
            //{
            //    Console.WriteLine("No se pueden AGREGAR Autos en competencias de Motos");
            //}

            //if(compeDeMotos + moto1)
            //{
            //    Console.WriteLine("Moto agregada con éxito");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo agregar");
            //}


            //if (compeDeMotos + moto2)
            //{
            //    Console.WriteLine("Moto agregada con éxito");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo agregar");
            //}

            //if (compeDeMotos + moto3)
            //{
            //    Console.WriteLine("Moto agregada con éxito");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo agregar POR FALTA DE CAPACIDAD");
            //}
            //Console.WriteLine(compeDeMotos.MostrarDatos());


            //----------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------
            //COMPETENCIA DE AUTOS, NO DEJA AGREGAR MOTOS.
            if (compeDeAutos + moto1)//INTENTO AGREGAR UNA MOTO.
            {
                Console.WriteLine("Moto agregado con éxito");
            }
            else
            {
                Console.WriteLine("No se pueden AGREGAR motos en competencias de AUTOS");
            }

            if (compeDeAutos + auto1)
            {
                Console.WriteLine("Auto agregado con éxito");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (compeDeAutos + auto2)
            {
                Console.WriteLine("Auto agregado con éxito");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }

            if(compeDeAutos + auto3)//PRUEBO LA CAPACIDAD DE LA COMPETENCIA.
            {
                Console.WriteLine("Auto agregado con éxito");
            }
            else
            {
                Console.WriteLine("No se pudo agregar, POR FALTA DE CAPACIDAD");
            }
            Console.WriteLine(compeDeAutos.MostrarDatos());


            Console.ReadKey();
        }
    }
}
