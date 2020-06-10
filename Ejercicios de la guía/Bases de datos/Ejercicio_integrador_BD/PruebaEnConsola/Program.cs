using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Clases_Instanciables;
using EntidadesAbstractas;

namespace PruebaEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralDeVentas cdv = new CentralDeVentas("Yago Center");
            CentralDeVentas retornoXML = new CentralDeVentas();
            List<Electrodomestico> lstEle = null;

            //Mantenimiento de casa:
            Aspiradora aspi01 = new Aspiradora("MX-010", "Aspiradora para el hogar", "Aspirar", 1750f, Electrodomestico.EColor.Blanco, true);

            //Alimentos
            Licuadora licu01 = new Licuadora("LIC-3000", "Licua alimentos de todo tipo", "Licuar alimentos", 1000f, Electrodomestico.EColor.Amarillo, false);

            //Higiene
            Depiladora depi01 = new Depiladora("DEPI-150", "Te arranca hasta el último bello", "Arrancar pelos", 7500f, Electrodomestico.EColor.Negro, true);

            cdv += aspi01;
            cdv += licu01;
            cdv += depi01;

            try
            {
                CentralDeVentas.Guardar(cdv);

                Console.WriteLine("Serializado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                retornoXML = CentralDeVentas.Leer();
                Console.WriteLine("Deserializando...");
                Thread.Sleep(1000);
                Console.WriteLine(retornoXML.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Beep();
            Console.ReadKey();
            Console.Clear();


            //----------------------------- BASES DE DATOS. -----------------------------
            //INSERTAR
            try
            {
                //QUE EL MÉTODO GUARDAR TOME UNA LISTA DE OBJS
                int countAgregados = 0;
                foreach (Electrodomestico item in cdv.ListaElectrodomesticos)
                {
                    if (ElectrodomesticoDAO.Guardar(item))
                    {
                        Console.WriteLine("Agregando elemento a la base de datos...(PROGRESS BAR)");
                        Thread.Sleep(1000);
                        countAgregados++;
                    }
                    else
                    {
                        Console.WriteLine($"No pudo agregarse el producto: {item.GetType()}");
                    }
                }
                Console.WriteLine($"Electrodomesticos agregados al depósito: {countAgregados}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            //SELECT
            try
            {
                //Traigo los electrodomesticos de la BDd
                lstEle = ElectrodomesticoDAO.Leer();
                Console.WriteLine("     ELECTRODOMESTICOS DEL DEPOSITO");
                foreach (Electrodomestico item in lstEle)
                {
                    Console.WriteLine(item + "\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            //DELETE (POR ID)
            try
            {
                if(ElectrodomesticoDAO.Borrar(2))
                    Console.WriteLine("Eliminado con éxito");
                else
                    Console.WriteLine("No existe ese ID o fue borrado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            //MODIFICAR 
            try
            {
                Electrodomestico nuevoEle = new Electrodomestico();

                nuevoEle.Modelo = "DNP-150";
                nuevoEle.Descripcion = "Nuevo modelo con TURBO";
                nuevoEle.FuncPrincipal = "Aspirar liquidos";
                nuevoEle.PrecioNeto = 9500f;
                nuevoEle.Color = Electrodomestico.EColor.Amarillo;
                nuevoEle.Garantia = true;

                if(ElectrodomesticoDAO.Modificar(nuevoEle, 1))
                {
                    Console.WriteLine("Modificación realizada con éxito");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


            Console.WriteLine("\n     Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
