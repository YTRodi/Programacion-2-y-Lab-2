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
    public partial class FormCantina : Form
    {
        private Botella.Tipo tipo;

        public string GetInforme
        {
            get
            {
                StringBuilder botellaEnLista = new StringBuilder();
                foreach (Botella item in this.barra1.BarraGetCantina.Botellas)
                {
                    botellaEnLista.AppendLine(item);
                    //llama a operador implicito nuevo que cree en botella.
                    //no hace falta castear, porque el item sería botella.
                }
                return botellaEnLista.ToString();
            }

        }

        public Cantina GetCantina
        {
            get
            {
                return this.barra1.BarraGetCantina;
            }
        }

        public FormCantina(int cantidadEspacios)
        {
            InitializeComponent();
            this.barra1.SetCantina = new Cantina(cantidadEspacios);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.barra1.SetCantina = Cantina.GetCantina(10);
            //this.barra1.SetCantina = new Cantina((int)numUDCapacidad.Value);
            //this.barra1.SetCantina = new Cantina(FrmCantidadEspaciosCantina);


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
                    txtBoxMarca.Text = string.Empty;
                }
            }
            else
            {
                Agua aguita = new Agua(auxCapacidad, txtBoxMarca.Text, auxContenido);
                if (!(aguita is null))
                {
                    barra1.AgregarBotella(aguita);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                //el usuario esta queriendo cerrar el formulario.
                //si la razon del cierre, el usuario quiere cerrarlo, no lo cierres.
                //FormClosingEventArgs = el tipo que venia asociado con el evento
                e.Cancel = true;
            }
        }
    }
}
