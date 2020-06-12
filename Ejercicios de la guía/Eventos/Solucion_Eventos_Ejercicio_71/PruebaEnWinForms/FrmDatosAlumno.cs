using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEnWinForms
{
    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        public FrmDatosAlumno()
        {
            InitializeComponent();
        }
        public void ActualizarAlumno(Entidades.Alumno pAlumno)
        {
            //Cambié a protected el modificador de acceso en FrmAltaAlumno.Designer
            //Entro a ver eso con ALT + F12.
            base.txtBoxNombre.Text = pAlumno.Nombre;
            base.txtBoxApellido.Text = pAlumno.Apellido;
            base.txtBoxDni.Text = pAlumno.Dni.ToString();
            base.txtBoxFoto.Text = pAlumno.RutaDeLaFoto;

            this.pBoxAlumno.ImageLocation = pAlumno.RutaDeLaFoto;
        }
    }
}
