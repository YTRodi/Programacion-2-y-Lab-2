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
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.mostrarToolStripMenuItem.Enabled = false;
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

    }
}
