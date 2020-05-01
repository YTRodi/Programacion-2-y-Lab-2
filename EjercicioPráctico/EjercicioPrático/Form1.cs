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
    public partial class Form1 : Form
    {
        bool cambiar;
        public Form1()
        {
            this.cambiar = false;
            InitializeComponent();
        }

        public Form1(bool cambiar,string usuario) : this()
        {
            this.cambiar = cambiar;
            this.txtUsuario.Text = usuario;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.cambiar)
            {
                Form2 frmPerrito = new Form2("Bienvenido " + txtUsuario.Text, txtUsuario.Text, txtContraseña.Text);
                frmPerrito.Show();
                this.Hide();
            }
            else
            {
                if (txtContraseña.Text == "asd123" && txtUsuario.Text == "pepito")
                {
                    Form2 frmPerrito = new Form2("Bienvenido " + txtUsuario.Text, txtUsuario.Text, txtContraseña.Text);
                    frmPerrito.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error, contraseña incorrecta");
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(this.cambiar)
            {
                this.Text = "Cambiar contraseña";
                this.btnLogin.Text = "Guardar nueva contraseña";
                this.txtUsuario.Enabled = false;
            }
        }
    }
}
