using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmployee = 4;
            int[] valorHora = {30,48,12,45 };
            string[] nombreEmpleado = { "Yago", "Joaco","Gabi","Facu" };
            int[] antiguedad = {10,15,20,34 };
            int[] horasTrabajadas = { 208, 200, 140, 160 };//por mes

            //float calculo = CalcularImporte(valorHora, horasTrabajadas, antiguedad);


            int calculo = (valorHora[0] * horasTrabajadas[0]) * (antiguedad[0] * 150);
            int final = calculo - calculo * 13 / 100;

            //for (int i = 0; i<cantidadEmployee;i++)
            //{
                Console.WriteLine("Nombre del empleado: " + nombreEmpleado[0] +
                    "\nAntiguedad: " + antiguedad[0] +
                    "\nValorHora: " + valorHora[0] +
                    "\nTotal a cobrar: " + calculo);
            
            //}
        }

        //6733,8

        static float CalcularImporte(int[] paramValorHora ,int[] paramHorasTrabajadas, int[] paramAntiguedad)
        {
            //multiplicar el valor hora por la cantidad de horas trabajadas
            //hay que sumarle la cantidad de años trabajados por $150
            //al total de TODO ESTO, hay que restarle el 13%
            int primerCalculo = 0;
            int descuento = 13;
            float resultadoFinal = 0;
            for (int i=0;i<4;i++)
            {
                primerCalculo = paramValorHora[i] * paramHorasTrabajadas[i] + paramAntiguedad[i] * 150;
            }
            resultadoFinal = primerCalculo - primerCalculo * descuento / 100;
            
            return resultadoFinal;
        }
    }
 }

    /*class Empleado
    {
        private int valorHora;
        private string nombreEmpleado;
        private int antiguedad;
        private int horasTrabajadas;

        
        /*public int ValorHora
        {
            get 
            { 
                return this.valorHora; 
            }

            set
            {
                valorHora = value;
            }
            
        }
        public int CalcularImporteACobrar()
        {
            //multiplicar el valor hora por la cantidad de horas trabajadas
            //hay que sumarle la cantidad de años trabajados por $150
            //al total de TODO ESTO, hay que restarle el 13%
            int primerCalculo = valorHora * horasTrabajadas;
            int segundoCalculo = primerCalculo + (antiguedad * 150);



        }

        public int MostrarRecibo()
        {

        }
    }*/

