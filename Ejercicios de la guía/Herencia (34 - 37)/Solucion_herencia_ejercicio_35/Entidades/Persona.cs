using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        #region Properties
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region Constructores
        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dni: " + this.dni);
            sb.AppendLine("Nombre: " + this.nombre);
            return sb.ToString();
        }
        #endregion



    }
}
