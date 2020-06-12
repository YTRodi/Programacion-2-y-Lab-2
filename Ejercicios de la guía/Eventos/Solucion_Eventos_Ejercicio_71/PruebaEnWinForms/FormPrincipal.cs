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
    public partial class FormPrincipal : Form
    {
        #region Formularios a utilizar (Children)
        FrmTestDelegados formTestD;
        FrmMostrar formMostrar;
        FrmDatosAlumno formDatosAlumno;
        FrmAltaAlumno formAltaAlumno;
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.mostrarToolStripMenuItem.Enabled = false;
            this.datosAlumnoToolStripMenuItem.Enabled = false;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formTestD = new FrmTestDelegados();
            this.formTestD.MdiParent = this;
            this.formTestD.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formMostrar = new FrmMostrar();
            this.formMostrar.MdiParent = this;
            this.formMostrar.Show();

            //Asigno manejador al evento.
            //Con esto lo controlo, cada vez que ocurra un evento lo va a manejar dichos métodos
            this.formTestD.EventoActualizarNombre += this.formMostrar.ActualizarNombre;
            this.formTestD.EventoActualizarFoto += this.formMostrar.ActualizarFoto;
        }

        private void datosAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(this.formAltaAlumno is null))
            {
                this.formDatosAlumno = new FrmDatosAlumno();
                this.formDatosAlumno.MdiParent = this;
                this.formDatosAlumno.Show();

                //Agrego manejador (ActualizarAlumno) al evento ActualizarAlumno.
                this.formAltaAlumno.EventoActualizarAlumno += this.formDatosAlumno.ActualizarAlumno;
            }
            else
            {
                MessageBox.Show("FrmAltaAlumno no está instanciado.",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formAltaAlumno = new FrmAltaAlumno();
            this.formAltaAlumno.MdiParent = this;
            this.formAltaAlumno.Show();
            this.datosAlumnoToolStripMenuItem.Enabled = true;
        }
    }
}
