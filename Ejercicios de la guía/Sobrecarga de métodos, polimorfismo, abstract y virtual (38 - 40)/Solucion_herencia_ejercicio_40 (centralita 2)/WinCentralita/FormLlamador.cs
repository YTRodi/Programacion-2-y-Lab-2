using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCentralita
{
    public partial class FormLlamador : Form
    {
        Centralita centralitaLlamador;

        #region Properties
        public Centralita Centralita
        {
            get
            {
                return this.Centralita;
            }
        }
        #endregion

        public FormLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralitaLlamador = centralita;
            //hacer lo mismo en formMostrar
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btn_asterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btn_numeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }
    }
}
