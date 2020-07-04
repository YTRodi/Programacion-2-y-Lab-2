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
    public partial class FormAltaPaciente : Form
    {
        public FormAltaPaciente()
        {
            InitializeComponent();
        }

        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
