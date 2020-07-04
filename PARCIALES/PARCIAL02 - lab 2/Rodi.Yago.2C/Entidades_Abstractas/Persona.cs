using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades_Abstractas
{
    [Serializable]
    public abstract class Persona
    {
        #region Enumerados
        /// <summary>
        /// Enumerado que contine el sexo que podrá tener la Persona.
        /// No estigmatizar, es sólo un ejemplo.
        /// </summary>
        public enum ESexo { Masculino, Femenino, Otro }
        #endregion

        #region Atributos
        protected int id;
        protected string apellido;
        protected string nombre;
        protected int edad;
        protected ESexo sexo;
        protected string direccion;
        protected int dni;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Id de la Persona.
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Apellido de la Persona.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Nombre de la Persona.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = this.ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el DNI de la Persona.
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(value); }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la Edad de la Persona.
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Sexo de la Persona.
        /// </summary>
        public ESexo Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la Direccion de la Persona.
        /// </summary>
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de la clase Persona.
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor que inicializa los campos:
        ///  apellido, nombre, edad, sexo, direccion y dni.
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="dni"></param>
        public Persona(string apellido, string nombre, int edad, ESexo sexo, string direccion, int dni)
            : this()
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Direccion = direccion;
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor que reutiliza el anterior e inicializa el campo:
        ///  Id.
        /// Como ninguno puede ser null, tienen que inicializarse TODOS los campos (Para la base de datos).
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        public Persona(int id, string apellido, string nombre, int edad, ESexo sexo, string direccion, int dni)
            : this(apellido, nombre, edad, sexo, direccion, dni)
        {
            this.Id = id;
        }
        #endregion

        #region Métodos
        /// <summary>
		/// Método que valida el nombre y apellido de la persona.
		/// </summary>
		/// <param name="dato"></param>
		/// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            Regex expresionRegular = new Regex("^[a-zA-ZÁÉÍÓÚáéíóú]*$");
            string retornoStr = null;

            if (expresionRegular.IsMatch(dato))
                retornoStr = dato;

            return retornoStr;
        }

        /// <summary>
        /// Método que válida que el dni tenga 
        /// OBLIGATORIAMENTE 8 caracteres.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(int dato)
        {
            int retornoDni = default(int);

            if (dato.ToString().Length == 8)
                retornoDni = dato;

            return retornoDni;
        }
        #endregion

        #region Operaciones
        /// <summary>
        /// Sobrecarga del operador ==.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Si dos personas son iguales (DNI iguales).</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            bool sonIguales = false;

            if (p1.DNI == p2.DNI)
                sonIguales = true;

            return sonIguales;
        }

        /// <summary>
        /// Sobrecarga del operador !=.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Si dos personas son distintas (DNI iguales).</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
