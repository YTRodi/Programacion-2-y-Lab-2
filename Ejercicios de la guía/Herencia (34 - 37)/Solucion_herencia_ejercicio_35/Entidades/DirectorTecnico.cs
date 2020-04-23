using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        #region Constructores
        private DirectorTecnico(string nombre) : base(nombre)
        {
            //emtpy.
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de la Persona: ");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Datos del director técnico: ");
            sb.AppendLine("Fecha de nacimiento: " + this.fechaNacimiento);
            return sb.ToString();
        }
        #endregion

        #region Operaciones
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            bool retorno = false;
            if(d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
        #endregion
    }
}
