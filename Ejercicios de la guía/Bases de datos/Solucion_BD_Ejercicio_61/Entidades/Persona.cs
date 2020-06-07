using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Attributes
        private int id;
        private string nombre;
        private string apellido;
        #endregion

        #region Properties
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        #endregion

        #region Constructors
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"ID: {this.ID} -- Nombre: {this.Nombre} -- Apellido: {this.apellido}";
        }
        #endregion
    }
}
