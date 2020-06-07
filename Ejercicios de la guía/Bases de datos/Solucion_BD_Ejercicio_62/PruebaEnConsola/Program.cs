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

            Local miLlamadaLocal = new Local("Berazategui", 21, "Bariloche", 10f);

            //Lista que contiene las llamadas que fueron subidas a la base de datos.
            List<Llamada> listaLLamadasDB = new List<Llamada>();
            try
            {
                central += l1;
                central += l2;
                central += l3;
                central += l4;
                central += miLlamadaLocal;

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
