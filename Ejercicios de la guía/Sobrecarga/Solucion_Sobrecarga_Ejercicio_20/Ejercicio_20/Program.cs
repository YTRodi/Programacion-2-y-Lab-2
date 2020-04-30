using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolarcito = new Dolar(10);
            Euro eurito = new Euro(10);
            Pesos pesito = new Pesos(10);

            if(dolarcito == eurito)
            {
                Console.WriteLine("son iguales");
            }

            ////PASAMANOS EURO A DOLAR Y EURO A PESO.
            //Dolar aux = (Dolar)eurito;
            //Console.WriteLine(aux.GetCantidad());
            //Pesos auxx = (Pesos)aux;
            //Console.WriteLine(auxx.GetCantidad());



            ////PASAMOS DOLAR A EURO Y DOLAR A PESO.
            //Euro auxEuro = (Euro)dolarcito;
            //Console.WriteLine(auxEuro.GetCantidad());
            //Pesos auxPeso = (Pesos)dolarcito;
            //Console.WriteLine(auxPeso.GetCantidad());


            ////PASAMOS PESO A EURO Y PESO A DOLAR
            //auxEuro = (Euro)pesito;
            //Console.WriteLine(auxEuro.GetCantidad());
            //aux = (Dolar)pesito;
            //Console.WriteLine(aux.GetCantidad());
            
            //PRUEBA 1.
            //dolarcito = 5;//ESTO GRACIAS A LA CONVERSION IMPLICITA DE DOLAR. (PASA UN DOUBLE A DOLAR).
            //dolarcito = (Dolar)eurito; //CORRECTO. CONVERSION EXPLICITA EURO A DOLAR.
            //dolarcito = (Dolar)pesito; //CORRECTO. CONVERSION EXPLICITA PESOS A DOLAR.
            //Console.WriteLine(dolarcito.GetCantidad());


            //PRUEBA 2 - OPERACION == Y !=
            //if (dolarcito == eurito)
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("no son iguales");
            //}


            ////PRUEBA 3 - OPERACIONES + Y -
            //Dolar sumaDolar = dolarcito + eurito;
            //Console.WriteLine("dolarcito + dolarcito " + dolarcito.GetCantidad() + dolarcito.GetCantidad());//concatena????
            //Console.WriteLine("dolarcito(10) + eurito(10) U$D26,599: " + sumaDolar.GetCantidad());
            //sumaDolar = dolarcito + pesito;
            //Console.WriteLine("dolarcito(10) + pesito(5) U$S10,130: " + sumaDolar.GetCantidad());
            //Console.WriteLine("=====================================================");




            //Euro sumaEuro = eurito + dolarcito;
            //Console.WriteLine("eurito + eurito " + eurito.GetCantidad() + eurito.GetCantidad());//concatena????
            //Console.WriteLine("eurito(10) + dolarcito(10) €16,024: " + sumaEuro.GetCantidad());
            //sumaEuro = eurito + pesito;
            //Console.WriteLine("eurito(10) + pesito(5) €10,078: " + sumaEuro.GetCantidad());
            //Console.WriteLine("=====================================================");



            //Pesos sumaPesos = pesito + dolarcito;
            //Console.WriteLine("pesito + pesito " + pesito.GetCantidad() + pesito.GetCantidad());//concatena????
            //Console.WriteLine("pesito(5) + dolarcito(10) $388,300: " + sumaPesos.GetCantidad());
            //sumaPesos = pesito + eurito;
            //Console.WriteLine("pesito(5) + eurito(10) $641,278: " + sumaPesos.GetCantidad());
            //Console.WriteLine("=====================================================");

            Console.ReadKey();
        }
    }
}
