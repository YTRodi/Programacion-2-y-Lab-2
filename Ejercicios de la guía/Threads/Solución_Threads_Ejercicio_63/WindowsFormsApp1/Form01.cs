using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form01 : Form
    {
        Thread hilo;
        public Form01()
        {
            InitializeComponent();
        }

        //CON ESTO TILDAS EL UNIVERSO
        //No se puede acceder a un hilo principal de un formulario.
        private void Form02_Load(object sender, EventArgs e)
        {
            this.hilo = new Thread(AsignarHora);
            this.hilo.Start();
        }

        public void AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString();
        }

        private void Form02_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo.IsAlive)
                this.hilo.Abort();
        }
    }
}
