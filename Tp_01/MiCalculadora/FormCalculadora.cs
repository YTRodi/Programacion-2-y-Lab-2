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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form 
    {
        public FormCalculadora()
        {
            InitializeComponent();
            labelResultado.Text = "111";
            btnBinario.Enabled = true;
            btnDecimal.Enabled = true;
        }

        #region Métodos estáticos
        private static double Operar(string num1, string num2, string operador)
        {
            //Creo dos intancias del tipo Numero
            Numero aux1 = new Numero(num1);
            Numero aux2 = new Numero(num2);
            //retorno los valores.
            return Calculadora.Operar(aux1, aux2, operador);
        }

        private  void Limpiar()
        {
            labelResultado.ResetText();
            txtBoxNumero1.Clear();
            txtBoxNumero2.Clear();
            comboBoxOperaciones.ResetText();
            btnBinario.Enabled = false;
            btnDecimal.Enabled = false;
        }
        #endregion


        private void btnOperar_Click(object sender, EventArgs e)
        {
            //Numero aux1 = new Numero(txtBoxNumero1.Text);
            //Numero aux2 = new Numero(txtBoxNumero2.Text);
            //labelResultado.Text = (Calculadora.Operar(aux1,aux2, comboBoxOperaciones.Text)).ToString();
            labelResultado.Text = FormCalculadora.Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, comboBoxOperaciones.Text).ToString();
            btnBinario.Enabled = true;
            btnDecimal.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            string aux = Numero.DecimalBinario(labelResultado.Text);
            labelResultado.Text = aux;

            btnDecimal.Enabled = true;
            btnBinario.Enabled = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            labelResultado.Text = Numero.BinarioDecimal(labelResultado.Text);
            btnBinario.Enabled = true;
            btnDecimal.Enabled = false;
        }
    }
}
