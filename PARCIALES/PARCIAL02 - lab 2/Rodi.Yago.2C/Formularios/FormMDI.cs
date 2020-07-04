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
using System.Runtime.InteropServices;
using Entidades_Instanciables;
using Entidades_Instanciables.Bases_de_datos;

namespace Formularios
{
    public partial class FormMDI : Form
    {
        #region Atributos
        FormMenuClinica frmMenuClinica;
        FormSalaEspera frmSalaEspera;
        FormAtendiendo frmAtendiendo;

        Thread hiloFechaYHora;
        delegate void Callback();

        #endregion

        /// <summary>
        /// Constructor por defecto del formulario MDI.
        /// </summary>
        public FormMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PictureBox que al presionarlo cierra la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Manejador de evento que cierra finaliza todos los hilos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Va a producirse una excepción si comento la hora en el Load
            if (this.hiloFechaYHora.IsAlive)
                this.hiloFechaYHora.Abort();
        }

        /// <summary>
        /// Manejador del evento Load que instancia los formularios "children" al MDI.
        /// 
        /// También Asigna los manejadores de eventos para los distintos eventos que se produzcan.
        /// 
        /// Por último posee un detalle que muestra la fecha y hora en tiempo real.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMDI_Load(object sender, EventArgs e)
        {
            // NO TOCAR.
            List<Turno> lstTurnosFinalizados = TurnoDAO.ListarTurnos();

            this.frmAtendiendo = new FormAtendiendo(lstTurnosFinalizados);//ACA VAAA);
            this.frmAtendiendo.MdiParent = this;
            this.frmAtendiendo.StartPosition = FormStartPosition.Manual;
            this.frmAtendiendo.Location = new Point(447, 278);
            this.frmAtendiendo.Show();

            this.frmSalaEspera = new FormSalaEspera();
            this.frmSalaEspera.MdiParent = this;
            this.frmSalaEspera.StartPosition = FormStartPosition.Manual;
            this.frmSalaEspera.Location = new Point(0, 278);
            this.frmSalaEspera.Show();

            this.frmMenuClinica = new FormMenuClinica();
            this.frmMenuClinica.MdiParent = this;
            this.frmMenuClinica.StartPosition = FormStartPosition.Manual;
            this.frmMenuClinica.Location = new Point(0, 0);
            this.frmMenuClinica.Show();

            this.AsignacionDeManejadoresDeEventos();

            //Hora en tiempo real (comentar para poder debuggear bien y no moleste.)
            this.hiloFechaYHora = new Thread(new ThreadStart(this.IncrementarHora));
            this.hiloFechaYHora.Start();
        }

        /// <summary>
        /// Método que asigna los manejadores a los eventos.
        /// </summary>
        public void AsignacionDeManejadoresDeEventos()
        {
            /*Asignación de manejadores a eventos para actualizar listBox (Simulación de turnos).*/
            this.frmMenuClinica.EventoActualizarLstBoxEnEspera += this.frmSalaEspera.ActualizarListBoxEnEspera;
            this.frmMenuClinica.EventoActualizarLstBoxAtendiendo += this.frmAtendiendo.ActualizarListBoxAtendiendo;

            //Limpiar listBoxs
            this.frmMenuClinica.EventoLimpiarListBoxEnEspera += this.frmSalaEspera.LimpiarListBoxEspera;
            this.frmMenuClinica.EventoLimpiarListBoxAtendiendo += this.frmAtendiendo.LimpiarListBoxAtendiendo;
        }

        #region Métodos actualizar lbl
        /// <summary>
        /// Método que asigna la hora.
        /// Si está en el hilo principal, llama recursivamente al mismo método
        /// para luego poder modificar un control.
        /// </summary>
        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                Callback aux = new Callback(this.AsignarHora);
                this.Invoke(aux);
            }
            else
            {
                this.lblHora.Text = "Fecha y hora: " + DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Método que posee un bucle infinito y lo único que hace es ejecutar el método
        /// AsignarHora() simulando la fecha y hora en tiempo real.
        /// </summary>
        public void IncrementarHora()
        {
            do
            {
                this.AsignarHora();
                Thread.Sleep(1000);

            } while (true);
        }
        #endregion


        #region Yapa para poder mover el formulario desde el panel
        /*No me debaja, ya que le cambie la propiedad "FormBorderStyle" a "None".*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}
