using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        Random numeroRandom = new Random();

        /// <summary>
        /// Constructor por defecto modificado.
        /// </summary>
        public Alumno()
        {
            nota1 = 0;
            nota2 = 0;
            notaFinal = 0;//Caso contrario se inicializara en -1...??
            apellido = string.Empty;
            legajo = 0;
            nombre = string.Empty;
        }

        /// <summary>
        /// Mediante este método accedo a los atributos private.
        /// </summary>
        /// <param name="paramNota1"></param>
        /// <param name="paramNota2"></param>
        public void Estudiar(byte paramNota1, byte paramNota2)
        {
            this.nota1 = paramNota1;
            this.nota2 = paramNota2;
        }

        /// <summary>
        /// Calcula la nota final del alumno aleatoriamente entre 0 y 10.
        /// </summary>
        public void CalcularFinal()
        {
            if(nota1 >= 4 && nota2 >=4)
            {
                
                notaFinal = numeroRandom.Next(0, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        /// <summary>
        /// Muestra los datos del alumno.
        /// </summary>
        public void Mostrar()
        {
            if(notaFinal != -1)
            {
                Console.WriteLine("Nota 1: " + nota1);
                Console.WriteLine("Nota 2: " + nota2);
                Console.WriteLine("NotaFinal: " + notaFinal);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Legajo: " + legajo);
                Console.WriteLine("Nombre: " + nombre + "\n");
            }
            else
            {
                Console.WriteLine("Alumno desaprobado: " + nombre + "\n");
            }
        }
    }
}
