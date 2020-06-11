using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form03 : Form
    {
        Thread t;
        delegate void Callback(object t);
        public Form03()
        {
            InitializeComponent();
        }

        private void Form03_Load(object sender, EventArgs e)
        {
        }

        #region Métodos para manejar hilo secundario
        private void btnEntrarHiloP_Click(object sender, EventArgs e)
        {
            t = new Thread(new ParameterizedThreadStart(this.AlterarLabel));
            t.Start("Hola! estas dentro del hilo principal (con parámetros)");
        }

        private void btnSalirHiloP_Click(object sender, EventArgs e)
        {
            this.t.Abort();
            this.lbl01.Text = "Saliste del hilo principal.(Abortaste)";
        }

        private void Form03_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.t.IsAlive)
                this.t.Abort();
        }
        #endregion

        #region Métodos para el label
        private void AlterarLabel(object texto)
        {
            if (this.lbl01.InvokeRequired)
            {
                Callback cb = new Callback(this.AlterarLabel);
                Object[] arrayObj = new Object[] { texto };
                this.Invoke(cb, arrayObj);
            }
            else
            {
                this.lbl01.Text = texto.ToString();
            }
        }
        #endregion
    }
}
