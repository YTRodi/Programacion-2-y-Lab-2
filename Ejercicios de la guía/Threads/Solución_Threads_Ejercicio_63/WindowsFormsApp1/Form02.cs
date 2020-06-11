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

//using System.Timer; //pasa salvar la ambiguedad, uso un alias o ... pongo System.Timer.Timer
namespace WindowsFormsApp1
{
    public partial class Form02 : Form
    {
        private Thread hilo;
        public Form02()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////ThreadStart ts = new ThreadStart(this.IncrementarHora);
            ////this.hilo = new Thread(ts);            

            ///ThreadStart = Recibe la referencia al método y lo guarda adentro del hilo, 
            //para cuando empiece el hilo ejecute dicho método*/
            //this.hilo = new Thread(new ThreadStart(this.IncrementarHora));
            //this.hilo.Start();
        }

        delegate void Callback();
        public void AsignarHora()
        {
            //Le preguntamos al control si necesita ser invocado el hilo principal
            /* TRUE = si estamos ejecutandolo desde un hilo secundario 
             * FALSE = ejecutando desde el hilo principal*/
            if (this.lblHora.InvokeRequired)
            {
                //El delegado va a contener un puntero al método AsignarHora
                Callback aux = new Callback(this.AsignarHora);

                //ejecuto el método AsignarHora
                /*Mediante un delegado, invocamos al hilo principal, para que este altere
                 al control*/
                this.Invoke(aux);
            }
            else
            {
                //LO ÚNICO QUE HACE EL ELSE
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Va a contener el do while
        /// </summary>
        public void IncrementarHora()
        {
            do
            {
                //Se realiza en el segundo hilo... no en el principal
                this.AsignarHora();
                Thread.Sleep(1000);

            } while (true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo.IsAlive)
                this.hilo.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ThreadStart = Recibe la referencia al método y lo guarda adentro del hilo, 
            para cuando empiece el hilo ejecute dicho método*/
            this.hilo = new Thread(new ThreadStart(this.IncrementarHora));
            this.hilo.Start(); //hace el invoke de IncrementarHora PERO en el hilo secundario.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.hilo.Abort();
            this.lblHora.Text = "Hilo abortado";
        }
    }
}
