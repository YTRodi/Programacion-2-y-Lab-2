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
    public partial class FrmTestDelegados : Form
    {
        public event FrmMostrar.DlgActualizarString EventoActualizarNombre;

        public FrmTestDelegados()
        {
            InitializeComponent();
        }
       
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.EventoActualizarNombre.Invoke(this.txtBoxDatos.Text);
        }
    }
}
