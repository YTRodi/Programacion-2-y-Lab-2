using CentralitaHerencia;
using EntidadesDAO;
using System;
using System.CodeDom;
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
            Centralita central = new Centralita("Yago Center");

            //Llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial("Quilmes", Provincial.Franja.Franja_3, 12, "CABA");

            //Lista que contiene las llamadas que fueron subidas a la base de datos.
            List<Llamada> listaLLamadasDB = new List<Llamada>();
            try
            {
                central += l1;
                central += l2;
                central += l3;
                central += l4;

                if (LocalDAO.Guardar(l1) && LocalDAO.Guardar(l3))
                    Console.WriteLine("La llamada LOCAL se cargó correctamente en la base de datos");
                else
                    Console.WriteLine("ERROR");


                if (provincialDAO.Guardar(l2) && provincialDAO.Guardar(l4))
                    Console.WriteLine("La llamada LOCAL se cargó correctamente en la base de datos");
                else
                    Console.WriteLine("ERROR");


                //Traigo las llamadas de la BD
                listaLLamadasDB = LocalDAO.Leer();
                Console.WriteLine("Llamadas leídas correctamente");
                Console.WriteLine(LocalDAO.MostrarDatos(listaLLamadasDB));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
