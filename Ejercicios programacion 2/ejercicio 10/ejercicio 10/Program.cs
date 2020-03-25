using System;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero para la altura de la piramide: ");
            int numeroIngresado = int.Parse(Console.ReadLine());
            int lineaActual;
            int espacio;
            int asterisco;

            for(lineaActual=1;lineaActual<=numeroIngresado;lineaActual++) //controla los saltos de linea hasta que llegue al numero que ingrese el usuario
            {
                /* cada ciclo se va restando de a uno.
                 * -El numeroIngresado siempre va a ser el mismo.
                 */
                for(espacio = 0 ; espacio < numeroIngresado - lineaActual ; espacio++) // 2do for = gestiono los espacios.
                {
                    Console.Write(" ");
                }

                for(asterisco = 0; asterisco < (lineaActual * 2) -1 ; asterisco++ )// 3er for = imprimir los asteriscos. Los asteriscos suman de a dos
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }




            /*Console.Write("Ingrese numero para la altura de la piramide: ");
            int numeroIngresado = 3;//int.Parse(Console.ReadLine());
            int lineaActual, espacio, asterisco;

            for(lineaActual = 1; lineaActual <= numeroIngresado ; lineaActual++)//FOR 1
            {
                for(espacio = 0; espacio < numeroIngresado - lineaActual; espacio++)//FOR 2
                {
                    Console.Write(" ");
                }
                for(asterisco = 0; asterisco < (lineaActual * 2) - 1; asterisco++)//FOR 3
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();*/
        }
    }
}
