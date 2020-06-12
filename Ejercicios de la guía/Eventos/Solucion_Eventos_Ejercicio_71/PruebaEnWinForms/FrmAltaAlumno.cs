using Entidades;
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
    public partial class FrmAltaAlumno : Form
    {
        #region Delegados y Eventos para usar "ActualizarAlumno()"
        public delegate void DlgActualizarAlumno(Entidades.Alumno alumnoActualizar);
        public event DlgActualizarAlumno EventoActualizarAlumno;
        #endregion

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxFoto.Text = this.openFileDialog.FileName;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dniParseado = default(int);
            if(this.txtBoxNombre.Text != string.Empty &&
                this.txtBoxApellido.Text != string.Empty &&
                this.txtBoxDni.Text != string.Empty &&
                this.txtBoxFoto.Text != string.Empty)
            {
                if (int.TryParse(txtBoxDni.Text, out dniParseado))
                {
                    Alumno nuevoAlumno = new Alumno(txtBoxNombre.Text, txtBoxApellido.Text, dniParseado, txtBoxFoto.Text);
                    this.EventoActualizarAlumno.Invoke(nuevoAlumno);
                }
                else
                {
                    MessageBox.Show("No se aceptan dni con letras.",
                        "Notificación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacíos",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }
    }
}
