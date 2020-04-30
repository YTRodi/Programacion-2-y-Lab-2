using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FormCantina
{
    public partial class Form1 : Form
    {
        private Botella.Tipo tipo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int auxCapacidad = Convert.ToInt32(numUDCapacidad.Value);
            int auxContenido = Convert.ToInt32(numUDContenido.Value);
            
            if(radioBtnCerveza.Checked)
            {
                Cerveza cervecita = new Cerveza(auxCapacidad, txtBoxMarca.Text, tipo, auxContenido);
                //Cerveza(auxCapacidad, txtBoxMarca.Text, tipo, auxContenido);
                if(!(cervecita is null))
                {
                    barra1.AgregarBotella(cervecita);
                    MessageBox.Show("AGREGADO CON EXITOOOOO");
                    txtBoxMarca.Text = string.Empty;
                }
            }
            else
            {
                Agua aguita = new Agua(auxCapacidad, txtBoxMarca.Text, auxContenido);
                if (!(aguita is null))
                {
                    barra1.AgregarBotella(aguita);
                    MessageBox.Show("AGREGADO CON EXITOOOOO");
                    txtBoxMarca.Text = string.Empty;
                }

            }
            //Botella botellitaNueva = new Botella(txtBoxMarca.Text, auxCapacidad, auxContenido);

            //if(!(aguita is null))
            //{
            //    barra1.AgregarBotella(aguita);
            //}
        }

        private void radioBtnAgua_CheckedChanged(object sender, EventArgs e)
        {
            cmbBotellaTipo.Enabled = false;
        }

        private void radioBtnCerveza_CheckedChanged(object sender, EventArgs e)
        {
            cmbBotellaTipo.Enabled = true;
        }
    }
}
