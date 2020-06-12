using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PruebaEnWinForms
{
    public partial class FormPrincipal : Form
    {
        private Persona p1;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!(p1 is null))
                p1.EventoString += NotificarCambio;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(p1 is null)
            {
                p1 = new Persona(txtNombre.Text, txtApellido.Text);
                p1.EventoString += FormPrincipal.NotificarCambio;
                this.btnCrear.Text = "Actualizar";
            }

            if(this.txtNombre.Text.CompareTo(this.p1.Nombre) != 0)
            {
                this.p1.Nombre = this.txtNombre.Text;
            }
            if (this.txtApellido.Text.CompareTo(this.p1.Apellido) != 0)
            {
                this.p1.Apellido = this.txtApellido.Text;
            }
            //if(!(p1 is null))
            //{
            //    this.p1.Nombre = txtNombre.Text;
            //    this.p1.Apellido = txtApellido.Text;
            //}

            MessageBox.Show(this.p1.Mostrar());
        }

        /// <summary>
        /// Manejador de EventoString
        /// </summary>
        /// <param name="cambio"></param>
        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
