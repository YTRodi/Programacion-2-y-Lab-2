using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private string fotoAlumno;
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
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string RutaDeLaFoto
        {
            get { return this.fotoAlumno; }
            set { this.fotoAlumno = value; }
        }
        #endregion

        #region Constructores
        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.RutaDeLaFoto = ruta;
        }
        #endregion

        #region Métodos

        #endregion

        #region Conversiones

        #endregion

        #region Operaciones

        #endregion

        #region Override

        #endregion

    }
}
