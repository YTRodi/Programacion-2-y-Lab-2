using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        #region Atributos
        private string nombre;
        private DateTime fechaCreacion;
        #endregion

        #region Constructores
        public Equipo(string nombre)
        {
            this.nombre = nombre;
        }
        public Equipo(string nombre, DateTime fechaCreacion) : this(nombre)
        {
            this.fechaCreacion = fechaCreacion;
        }
        #endregion

        #region Properties
        public string NombreEquipo
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Métodos
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[Equipo: {this.nombre}] fundado el [{this.fechaCreacion}]");
            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Equipo eq1, Equipo eq2)
        {
            bool sonIguales = false;

            if (eq1.nombre == eq2.nombre)
                if (eq1.fechaCreacion == eq2.fechaCreacion)
                    sonIguales = true;

            return sonIguales;
        }

        public static bool operator !=(Equipo eq1, Equipo eq2)
        {
            return !(eq1 == eq2);
        }
        #endregion
    }
}
