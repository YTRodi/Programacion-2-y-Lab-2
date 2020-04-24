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
        private Centralita centralita;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Form formularioLlamada = new FormLlamador(centralita);
            formularioLlamada.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Centralita centralita = new Centralita("Yago Center");
            centralita = new Centralita("Yago Center");
        }
    }
}
