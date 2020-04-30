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

namespace FormsConversorNumeros
{
    public partial class FormularioConversor : Form
    {
        public FormularioConversor()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            double auxiliar = Conversor.BinarioDecimal(txtBinario.Text);

            txtResultadoDec.Text = auxiliar.ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if(double.TryParse(txtDecimal.Text,out aux))
            {
                txtResultadoBin.Text = Conversor.DecimalBinario(aux);
            }
        }

        private void FormularioConversor_Load(object sender, EventArgs e)
        {
            txtResultadoBin.Enabled = false;
            txtResultadoDec.Enabled = false;
        }
    }
}
