using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PruebaConsola
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public char sexo;
    }
    public class Lista
    {
        private List<Persona> items;

        public List<Persona> Items
        {
            get { return this.items; }
        }

        public Lista()
        {
            this.items = new List<Persona>();
        }

        public string MostrarDatosLista()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔═══════════════════════╗");
            sb.AppendLine($"║ Datos de las personas ║");
            sb.AppendLine("╚═══════════════════════╝");
            sb.AppendLine($"╔═══════════════════════╗");

            foreach (Persona item in this.Items)
            {
                sb.AppendLine($"    Nombre: {item.nombre}");
                sb.AppendLine($"    Apellido: {item.apellido}");
                sb.AppendLine($"    Edad: {item.edad}");
                sb.AppendLine($"    Sexo: {item.sexo}");
                sb.AppendLine($"╠═══════════════════════╣");


                //Console.WriteLine("{0,15}", nombrePrueba);//STRING CON CORRIMIENTO

            }
            return sb.ToString();
        }
    }
}
