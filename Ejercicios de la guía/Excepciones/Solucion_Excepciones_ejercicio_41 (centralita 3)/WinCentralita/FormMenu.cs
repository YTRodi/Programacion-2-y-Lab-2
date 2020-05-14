using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCentralita
{
    public partial class FormMenu : Form
    {
        private Centralita centralitaMenu;

        
        #region Constructores
        public FormMenu()
        {
            InitializeComponent();
            centralitaMenu = new Centralita("Yago Center");
        }
        #endregion

        #region Eventos de botones
        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FormLlamador formularioLlamada = new FormLlamador(centralitaMenu);
            formularioLlamada.ShowDialog();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Centralita centralita = new Centralita("Yago Center");
            centralitaMenu = new Centralita("Yago Center");
        }

       

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FormMostrar formularioMostrar = new FormMostrar(centralitaMenu);
            formularioMostrar.TipoLlamada = Llamada.TipoLLamada.Todas;
            formularioMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FormMostrar formularioMostrar = new FormMostrar(centralitaMenu);
            formularioMostrar.TipoLlamada = Llamada.TipoLLamada.Local;
            formularioMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FormMostrar formularioMostrar = new FormMostrar(centralitaMenu);
            formularioMostrar.TipoLlamada = Llamada.TipoLLamada.Provincial;
            formularioMostrar.ShowDialog();
        }
    }
}
