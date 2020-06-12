using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEnWinForms
{
    public partial class FrmTestDelegados : Form
    {
        #region Eventos propios
        public event FrmMostrar.DlgActualizarString EventoActualizarNombre;
        public event FrmMostrar.DlgActualizarString EventoActualizarFoto;
        #endregion

        #region Atributos
        private string pathFoto;
        #endregion

        public FrmTestDelegados()
        {
            InitializeComponent();
        }
        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.EventoActualizarNombre.Invoke(this.txtBoxDatos.Text);

            this.EventoActualizarFoto.Invoke(this.pathFoto);
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pathFoto = this.openFileDialog.FileName;
            }
            this.lblPath.Text += "\n" + this.pathFoto;
        }

        
    }
}
