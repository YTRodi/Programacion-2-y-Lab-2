using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace FormsConversor
{
    public partial class FormMonedas : Form
    {
        public FormMonedas()
        {
            InitializeComponent();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Enabled)
            {
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
                btnLockCotizacion.Image = imageList.Images[0];
            }
            else
            {
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                btnLockCotizacion.Image = imageList.Images[1];
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux = default(double);
            if(double.TryParse(txtCotizacionEuro.Text,out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtCotizacionPeso.Text, out aux))
            {
                Pesos.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionPeso.Focus();
            }
        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if(double.TryParse(txtEuro.Text,out aux))
            {
                Euro eurito = new Euro(aux);
                txtEuroAEuro.Text = eurito.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)eurito).GetCantidad().ToString();//primero transformo a dolar y despues paso a string.
                txtEuroAPeso.Text = ((Pesos)eurito).GetCantidad().ToString();//primero transformo a pesos y despues paso a string.
            }
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtDolar.Text, out aux))
            {
                Dolar dolarcito = new Dolar(aux);
                txtDolarAEuro.Text = ((Euro)dolarcito).GetCantidad().ToString();
                txtDolarADolar.Text = dolarcito.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Pesos)dolarcito).GetCantidad().ToString();
            }
        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtPeso.Text, out aux))
            {
                Pesos pesito = new Pesos(aux);
                txtPesoAEuro.Text = ((Euro)pesito).GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)pesito).GetCantidad().ToString();
                txtPesoAPeso.Text = pesito.GetCantidad().ToString();
            }

        }
    }
}
