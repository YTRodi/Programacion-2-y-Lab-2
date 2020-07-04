using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades_Abstractas;

namespace Entidades_Instanciables
{
    [Serializable]
    public class Paciente : Persona
    {
        #region Enumerados
        /// <summary>
        /// Enumerado que contine el tipo de obra social que podrá tener el Paciente.
        /// </summary>
        public enum EObraSocial {CoberturaBasica, CoberturaCompleta , NoTiene }
        #endregion

        #region Atributos
        private EObraSocial obraSocial;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la braSocial del Paciente.
        /// </summary>
        public EObraSocial ObraSocial
        {
            get { return this.obraSocial; }
            set { this.obraSocial = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Paciente.
        /// </summary>
        public Paciente()
        {

        }

        /// <summary>
        /// Constructor que llama a la base e inicializa los campos:
        ///  apellido, nombre, edad, sexo, direccion, dni y obraSocial.
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="dni"></param>
        /// <param name="obraSocial"></param>
        public Paciente(string apellido, string nombre, int edad, ESexo sexo, string direccion, int dni, EObraSocial obraSocial)
            :base(apellido, nombre, edad, sexo, direccion, dni)
        {
            this.ObraSocial = obraSocial;
        }

        /// <summary>
        /// Constructor que llama a la base que contiene el ID, solamente para traer los pacientes que se encuentran en la base de datos.
        /// Además inicializa los campos:
        ///  apellido, nombre, edad, sexo, direccion, dni y obraSocial.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="dni"></param>
        /// <param name="obraSocial"></param>
        public Paciente(int id, string apellido, string nombre, int edad, ESexo sexo, string direccion, int dni, EObraSocial obraSocial)
            : base(id, apellido, nombre, edad, sexo, direccion, dni)
        {
            this.ObraSocial = obraSocial;
        }
        #endregion

        #region Override
        /// <summary>
        /// Sobrescritura del método ToString().
        /// </summary>
        /// <returns>El id, apellido, nombre y obra social del Paciente.</returns>
        public override string ToString()
        {
            return $"ID: {this.Id} -- APELLIDO: {this.Apellido} -- NOMBRE: {this.Nombre} --  OBRA SOCIAL: {this.ObraSocial}";
        }
        #endregion


    }
}

