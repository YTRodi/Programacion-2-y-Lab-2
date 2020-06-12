using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEnWinForms
{
    public partial class FormPrincipal : Form
    {
        Temporizador miTemp;
        delegate void Callback();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            miTemp = new Temporizador();
            miTemp.Intervalo = 1000;
            miTemp.Activo = true;

            miTemp.EventoTiempo += MetodoManejador;
        }

        #region Método manejador para el EventoTiempo de la clase Temporizador
        public void MetodoManejador()
        {
            //this.lblFechaYHora.Text = DateTime.Now.ToString();
            //MessageBox.Show($"Pasaron los {miTemp.Intervalo} milisegundos \nEstado del temporizador {miTemp.Activo}");
            if (this.lblFechaYHora.InvokeRequired)
            {
                Callback aux = new Callback(this.MetodoManejador);
                this.Invoke(aux);
            }
            else
            {
                this.lblFechaYHora.Text = DateTime.Now.ToString();
            }
        }
        #endregion
    }

}





