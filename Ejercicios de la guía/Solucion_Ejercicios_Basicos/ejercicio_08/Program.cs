using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            //Variables
            char exit;
            double valorHora;
            string nombreEmpleado;
            double antiguedad;
            double horasTrabajadas;//por mes

            //Calculos
            double totalBruto;
            double totalNeto;
            double totalDescuento;
            double acumulador = 0;

            do
            {
                Console.Write("Ingrese el valor que gana por hora: ");
                valorHora = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nombre: ");
                nombreEmpleado = Console.ReadLine();

                Console.Write("Ingrese antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese horas trabajadas en el mes: ");
                horasTrabajadas = int.Parse(Console.ReadLine());

                totalBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);
                totalDescuento = totalBruto * 13 / 100;
                totalNeto = totalBruto - totalDescuento;

                Console.WriteLine("Nombre del empleado: " + nombreEmpleado);
                Console.WriteLine("Antiguedad: " + antiguedad);
                Console.WriteLine("Valor por hora: " + valorHora);
                Console.WriteLine("Total a cobrar en bruto: " + totalBruto);
                Console.WriteLine("Total de descuentos: " + totalDescuento);
                Console.WriteLine("Total neto a cobrar: " + totalNeto);

                acumulador = acumulador + totalNeto;
                Console.WriteLine("\nConfirma salir?");
                exit = char.Parse(Console.ReadLine());
            }
            while (exit == 'n' || exit == 'N');

            Console.WriteLine("Valor neto a cobrar de todos los empleados ingresados: $" + acumulador);

            //aca imprimo los empleados
            //pedir con un while los datos que te pide

            Console.ReadKey();
        }
    }
}
