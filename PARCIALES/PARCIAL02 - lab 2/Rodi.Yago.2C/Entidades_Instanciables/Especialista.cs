using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Abstractas;

namespace Entidades_Instanciables
{
    [Serializable]
    public class Especialista : Persona
    {
        #region Enumerados
        /// <summary>
        /// Enumerado que contine el tipo de especialidad que podrá tener el Especialista.
        /// </summary>
        public enum EEspecialidad
        {
            Oftalmologia,
            Odontologia,
            Otorrinolaringologia,
            Ginecologia,
            Dermatologia,
            Obtetricia,
            Pediatria,
            Psicologia,
            ClinicaGeneral
        }
        #endregion

        #region Atributos
        private EEspecialidad especialidad;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Campo del Especialista.
        /// </summary>
        public EEspecialidad Campo
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Especialista.
        /// </summary>
        public Especialista()
        {

        }

        /// <summary>
        /// Constructor que llama a la base e inicializa los campos:
        ///  apellido, nombre, edad, sexo, direccion, dni y Campo.
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="dni"></param>
        /// <param name="especialidad"></param>
        public Especialista(string apellido, string nombre, int edad, ESexo sexo, string direccion, int dni, EEspecialidad especialidad)
           : base(apellido, nombre, edad, sexo, direccion, dni)
        {
            this.Campo = especialidad;
        }


        /// <summary>
        /// Constructor que llama a la base que contiene el ID, solamente para traer los Especialistas que se encuentran en la base de datos.
        /// Además inicializa los campos:
        ///  apellido, nombre, edad, sexo, direccion, dni y Campo.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="dni"></param>
        /// <param name="especialidad"></param>
        public Especialista(int id, string apellido, string nombre, int edad, ESexo sexo, string direccion, int dni, EEspecialidad especialidad)
            : base(id, apellido, nombre, edad, sexo, direccion, dni)
        {
            this.Campo = especialidad;
        }
        #endregion

        #region Override
        /// <summary>
        /// Sobrescritura del método ToString().
        /// </summary>
        /// <returns>El id, apellido y Campo del Especialista.</returns>
        public override string ToString()
        {
            return $"ID: {this.Id} -- APELLIDO: {this.Apellido} -- ESPECIALIDAD: {this.Campo}";
        }
        #endregion

    }
}
