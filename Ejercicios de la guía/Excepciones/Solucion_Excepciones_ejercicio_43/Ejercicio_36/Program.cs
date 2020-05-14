using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

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


            //------------------------------------------------------------------------------------------------
            //-------------------------------------------AUTOS------------------------------------------------
            //------------------------------------------------------------------------------------------------
            //try
            //{
            //    if (compeDeAutos + auto1)
            //    {
            //        Console.WriteLine("Auto agregado con éxito");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudo agregar el auto");
            //    }
            //}
            //catch (CompetenciaNoDisponibleException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            ////INTENTO AGREGAR UNA MOTO A COMPETENCIA DE AUTOS.
            //try
            //{
            //    if (compeDeAutos + moto1)
            //    {
            //        Console.WriteLine("MOTO agregada con éxito");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no se pudo agregar la MOTO");
            //    }
            //}
            //catch (CompetenciaNoDisponibleException ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //}

            //try
            //{
            //    if (compeDeAutos + auto2)
            //    {
            //        Console.WriteLine("Auto agregado con éxito");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudo agregar el auto");
            //    }
            //}
            //catch (CompetenciaNoDisponibleException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //------------------------------------------------------------------------------------------------
            //-------------------------------------------MOTOS------------------------------------------------
            //------------------------------------------------------------------------------------------------
            try
            {
                if (compeDeMotos + moto1)
                {
                    Console.WriteLine("Moto agregado con éxito");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar la moto");
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //INTENTO AGREGAR UN AUTO A COMPETENCIA DE MOTOS
            try
            {
                if (compeDeMotos + auto1)
                {
                    Console.WriteLine("Moto agregado con éxito");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar la moto");
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            Console.ReadKey();
        }
    }
}
