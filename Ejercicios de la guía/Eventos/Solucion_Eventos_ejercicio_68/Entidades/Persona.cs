using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        #region Atributos
        string nombre;
        string apellido;
        #endregion

        #region Properties
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

        #region Constructores
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

        #region Métodos
        public string Mostrar()
        {
            return $"Nombre: {this.Nombre} -- Apellido: {this.Apellido}";
        }
        #endregion

        #region Eventos
        public event Entidades.DelegadoString EventoString;
        #endregion
    }
}
