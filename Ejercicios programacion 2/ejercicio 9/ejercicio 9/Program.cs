using System;

namespace ejercicio_9
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
                for(asterisco = 0; asterisco < (lineaActual * 2) -1 ; asterisco++ )// 3er for = imprimir los asteriscos. Los asteriscos suman de a dos
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            /*
			string asteriscoBase = "*";
            Console.Write("Ingrese numero para la altura de la piramide: ");
            int numeroIngresado = int.Parse(Console.ReadLine());

            for (int i=0;i<numeroIngresado;i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(asteriscoBase);// "*" es lo mismo
                }
                else
                {
                    asteriscoBase = asteriscoBase + "**";//el valor anterior le sumo 2 asteriscos
                    Console.WriteLine(asteriscoBase);
                }
            }
			*/
        }
    }
}
