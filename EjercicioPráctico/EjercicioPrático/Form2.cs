using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPrático
{
    public partial class Form2 : Form
    {
        string usuario;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string mensaje,string usuario, string contraseña) : this()
        {
            this.Text = mensaje; //cambio de nombre al formulario
            this.usuario = usuario;
            this.lblUsuario.Text = "Usuario actual: " + usuario;
            this.lblContraNueva.Text = "Contraseña actual: " + contraseña;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(true,usuario);
            f1.Show();
            //f1.Hide();
        }
    }
}
