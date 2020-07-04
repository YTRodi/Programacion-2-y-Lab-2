using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Abstractas
{
    [Serializable]
    public abstract class Institucion
    {
        #region Atributos
        private string razonSocial;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la RazonSocial de la Institución.
        /// </summary>
        public string RazonSocial
        {
            get { return this.razonSocial; }
            set { this.razonSocial = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Institucion.
        /// </summary>
        public Institucion()
        {

        }

        /// <summary>
        /// Constructor que reutiliza el anterior y inicializa el campo:
        ///  RazonSocial.
        /// </summary>
        /// <param name="razonSocial"></param>
        public Institucion(string razonSocial) : this()
        {
            this.RazonSocial = razonSocial;
        }
        #endregion
    }
}
