using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace PruebaEnConsola
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

            Competencia<AutoF1> compeDeAutos = new Competencia<AutoF1>(15, 2, Competencia<AutoF1>.TipoCompetencia.F1);//del tipo AutoF1
            Competencia<MotoCross> compeDeMotos = new Competencia<MotoCross>(20, 2, Competencia<MotoCross>.TipoCompetencia.MotoCross);

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

            Console.WriteLine(compeDeMotos.MostrarDatos());

            Console.ReadKey();
        }
    }
}
