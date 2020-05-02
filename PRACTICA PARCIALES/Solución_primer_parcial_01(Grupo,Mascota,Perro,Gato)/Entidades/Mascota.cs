using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        #region Atributos
        private string nombre;
        private string raza;
        #endregion


        #region Constructores
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Properties
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion

        #region Métodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            string retornoStr = string.Empty;
            retornoStr = string.Format("Nombre: {0} \nRaza: {1}", this.nombre, this.raza);
            return retornoStr;
        }
        #endregion


    }
}
