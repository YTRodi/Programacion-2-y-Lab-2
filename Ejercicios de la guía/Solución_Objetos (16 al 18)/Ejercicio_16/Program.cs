using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_16;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            #region Datos alumnos
                alumno1.nombre = "Cami";
                alumno1.apellido = "Roy";
                alumno1.legajo = 1001;

                alumno2.nombre = "Yago";
                alumno2.apellido = "Rodi";
                alumno2.legajo = 1002;

                alumno3.nombre = "Maggie";
                alumno3.apellido = "Zeppelin";
                alumno3.legajo = 1003;
            #endregion

            alumno1.Estudiar(10, 6);
            alumno1.CalcularFinal();
            alumno1.Mostrar();

            //alumno2.Estudiar(5, 2);
            //alumno2.CalcularFinal();
            //alumno2.Mostrar();

            //alumno3.Estudiar(9,9);
            //alumno3.CalcularFinal();
            //alumno3.Mostrar();



            Console.ReadKey();
        }
    }
}

