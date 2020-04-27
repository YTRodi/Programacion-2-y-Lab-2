using CentralitaHerencia;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                return this.centralitaLlamador;
            }
        }
        #endregion

        #region Constructores
        public FormLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralitaLlamador = centralita;
            //CARGO LAS FRANJAS.
            //DataSource = Obtiene o establece el origen de datos de este objeto.
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }
        #endregion

        #region Métodos del panel
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
            if(txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
        }
        #endregion

        #region Métodos operaciones
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random numRandomDuracion = new Random();
            Random numRandomCosto = new Random();
            string messageSuccess = "Llamada realizada con éxito.";

            if (txtNroDestino.Text[0] == '#')
            {
                //LECTURA
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);


                //AGREGO LLAMADA A LA CENTRAL
                Provincial llamadaProvincial = new Provincial(txtNroOrigen.Text, franjas, numRandomDuracion.Next(1, 50), txtNroDestino.Text);

                if (!(llamadaProvincial is null))
                {
                    centralitaLlamador += llamadaProvincial;
                    MessageBox.Show(messageSuccess, "Estado de la llamada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //SI NO ES PROVINCIAL, ES LOCAL.
                Local llamadaLocal = new Local(txtNroOrigen.Text, numRandomDuracion.Next(1, 50), txtNroDestino.Text, numRandomCosto.Next(5, 56) / 10f);

                if (!(llamadaLocal is null))
                {
                    centralitaLlamador += llamadaLocal;
                    MessageBox.Show(messageSuccess, "Estado de la llamada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //CIERRO EL FORM.
            this.Close();
        }
        #endregion

        private void FormLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.Enabled = false;
            //NO SE COMO HACER PARA QUE CUANDO TOQUE UN NUMERO SE BORRE DEL TEXTBOX EL STRING "NRO DESTINO".
            //txtNroDestino.Text = "Nro Destino";
            //txtNroOrigen.Text = "Nro Origen";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = string.Empty;
            txtNroOrigen.Text = string.Empty;
        }
    }
}
