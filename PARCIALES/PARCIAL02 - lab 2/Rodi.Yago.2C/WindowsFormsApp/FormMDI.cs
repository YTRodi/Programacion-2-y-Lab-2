using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormMDI : Form
    {
        #region Atributos
        FormMenuClinica frmMenuClinica;
        FormSalaEspera frmSalaEspera;
        FormAtendiendo frmAtendiendo;
        #endregion

        public FormMDI()
        {
            InitializeComponent();
        }

        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            // NO TOCAR.
            this.frmAtendiendo = new FormAtendiendo();
            this.frmAtendiendo.MdiParent = this;
            this.frmAtendiendo.StartPosition = FormStartPosition.Manual;
            this.frmAtendiendo.Location = new Point(447, 278);
            this.frmAtendiendo.Show();

            this.frmSalaEspera = new FormSalaEspera();
            this.frmSalaEspera.MdiParent = this;
            this.frmSalaEspera.StartPosition = FormStartPosition.Manual;
            this.frmSalaEspera.Location = new Point(0, 278);
            this.frmSalaEspera.Show();

            this.frmMenuClinica = new FormMenuClinica();
            this.frmMenuClinica.MdiParent = this;
            this.frmMenuClinica.StartPosition = FormStartPosition.Manual;
            this.frmMenuClinica.Location = new Point(0, 0);
            this.frmMenuClinica.Show();

            this.AsignacionDeManejadoresDeEventos();
        }
        public void AsignacionDeManejadoresDeEventos()
        {
            //Un evento puede contener varios manejadores.
            /*Asignación de manejadores a eventos.*/
            this.frmMenuClinica.EventoActualizarLstBoxEnEspera += this.frmSalaEspera.ActualizarListBoxEnEspera;
            this.frmMenuClinica.EventoActualizarLstBoxAtendiendo += this.frmAtendiendo.ActualizarListBoxAtendiendo;

            //Limpiar listBoxs
            this.frmMenuClinica.EventoLimpiarListBoxEnEspera += this.frmSalaEspera.LimpiarListBoxEspera;
            this.frmMenuClinica.EventoLimpiarListBoxAtendiendo += this.frmAtendiendo.LimpiarListBoxAtendiendo;
        }
    }
}
