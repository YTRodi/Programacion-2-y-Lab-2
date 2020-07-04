using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Abstractas;
using Entidades_Instanciables;
using Entidades_Instanciables.Bases_de_datos;
using Excepciones;
using Métodos_de_extensión;
using WindowsFormsApp.FormsInformativos;

namespace WindowsFormsApp
{
    public partial class FormMenuClinica : Form
    {
        #region Delegados y eventos para conectar información entre formularios.
        public delegate void DelegadoParaPasarTurnos(object obj);//en vez de enviar un obj, envio un turno?
        public event DelegadoParaPasarTurnos EventoActualizarLstBoxEnEspera;
        public event DelegadoParaPasarTurnos EventoActualizarLstBoxAtendiendo;
        #endregion


        #region Delegados y eventos para limpiar ListBox de otros formularios.
        public delegate void DelegadoParaLimpiarListBox();
        public event DelegadoParaLimpiarListBox EventoLimpiarListBoxEnEspera;
        public event DelegadoParaLimpiarListBox EventoLimpiarListBoxAtendiendo;
        #endregion

        #region Atributos
        private Clinica miClinica;
        #endregion

        #region Atributos para generar observaciones random
        private Random rnd = new Random();
        private string[] arrayObservaciones = new string[]
        {
            "Esta bien.",
            "Tiene que hacer reposo.",
            "No cumplió con el reposo.",
            "Esta mal.",
            "Tiene que continuar con el tratamiento",
            "Al quirófano de una.",
            "Le queda una semana.",
            "Esta regular.",
            "Le queda 1 día",
            "Le quedan 3 segundos de vida.",
            "No cumplió con la cuarentena.",
            "Bye bye"
        };
        #endregion

        #region Paths de salida
        string pathPacientesSegundaClinica = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\ArchivosClinica" + @"\PacientesSegundaClinica.xml";
        string pathEspecialistasSegundaClinica = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\ArchivosClinica" + @"\DoctoresSegundaClinica.xml";
        //static string pathLog = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt";
        //static string fechaLog = "\nFECHA: " + DateTime.Now.ToString($"dddd dd 'de' MMMM 'de' yyyy HH:mm 'hr'");
        #endregion

        public FormMenuClinica()
        {
            InitializeComponent();
        }

        private void FormMenuClinica_Load(object sender, EventArgs e)
        {

            try
            {
                this.miClinica = new Clinica("Clínica");
                this.Text = string.Format("{0,150}", this.miClinica.RazonSocial);

                this.CargarListasDePacientesDeLaBD();
                this.CargarListBoxDesdeBDYArchivosXml();
            }
            catch (ArchivosException aEx)
            {
                this.MostrarMsgException(aEx);
                GyLString.Guardar(aEx.Message + GyLString.fechaLog, GyLString.pathLog);
            }
            catch (BDException bdEx)
            {
                this.MostrarMsgException(bdEx);
                GyLString.Guardar(bdEx.Message + GyLString.fechaLog, GyLString.pathLog);
            }
            catch (Exception ex)
            {
                this.MostrarMsgException(ex);
                GyLString.Guardar(ex.Message + GyLString.fechaLog, GyLString.pathLog);
            }
        }

        private void FormMenuClinica_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.miClinica.FinTurnos();
        }

        #region Botón de asignar turno y su métodos

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                  Para Seleccionar pacientes y especialistas al azar y 
                  poder formar turnos si cumplen todos los parámetros.
                */
                this.lstBoxPacientes.SelectedIndex = this.rnd.Next(this.miClinica.ListaPacientes.Count);
                this.lstBoxEspecialistas.SelectedIndex = this.rnd.Next(this.miClinica.ListaEspecialistas.Count);

                Turno nuevoTurno = new Turno(miClinica.ListaPacientes[lstBoxPacientes.SelectedIndex], miClinica.ListaEspecialistas[lstBoxEspecialistas.SelectedIndex], arrayObservaciones[this.rnd.Next(0, 11)], DateTime.Now);

                nuevoTurno.EventoPasaEstado += turno_InformaEstado;

                this.miClinica += nuevoTurno;
            }
            catch (TurnoException tEx)
            {
                this.MostrarMsgException(tEx);

                GyLString.Guardar(tEx.Message + GyLString.fechaLog, GyLString.pathLog);
            }
            catch (ArgumentException)//Puede ejecutarse cuando no elijo aleatoriamente los pacientes y especialistas.
            {
                this.MostrarError("Ninguna persona y/o especialista fue seleccionado/a de las listas.");
                GyLString.Guardar("Ninguna persona y/o especialista fue seleccionado/a de las listas." + GyLString.fechaLog, GyLString.pathLog);
            }
            catch (Exception ex)
            {
                this.MostrarMsgException(ex);
                GyLString.Guardar(ex.Message + GyLString.fechaLog, GyLString.pathLog);
            }
        }

        private void turno_InformaEstado(object obj)
        {
            //Esto es para acceder al hilo principal y poder modificar el control.
            if (this.InvokeRequired)
            {
                Turno.DelegadoTurnoEstado dp = new Turno.DelegadoTurnoEstado(this.turno_InformaEstado);

                Object[] arrayObj = new object[] { obj };

                this.Invoke(dp, arrayObj);
            }
            else
            {
                this.ActualizarListBoxDeTurnos();
            }
        }

        private void ActualizarListBoxDeTurnos()
        {
            //this.aux.LstBoxEspera.Items.Clear();
            /*Puedo poner un evento que me limpie los lstBox.*/
            this.EventoLimpiarListBoxEnEspera();
            this.EventoLimpiarListBoxAtendiendo();

            foreach (Turno item in this.miClinica.Turnos)
            {
                switch (item.Estado)
                {
                    case Turno.EEstado.EnEspera:
                        this.EventoActualizarLstBoxEnEspera.Invoke(item);
                        break;

                    case Turno.EEstado.Atendiendo:
                        this.EventoActualizarLstBoxAtendiendo.Invoke(item);
                        break;

                    case Turno.EEstado.Atendido:
                        /*
                         * TODO:
                         * Falta crear formulario para mostrar los datos de los atendidos.
                         */
                        //MessageBox.Show($"Turno guardado en la base de datos!\nESTADO: {item.Estado}",
                        //    "Notificación",
                        //    MessageBoxButtons.OK,
                        //    MessageBoxIcon.Information);

                        break;
                }
            }
        }
        #endregion

        #region Métodos que cargan las listas (Desde la base de datos y los archivos XML)
        public void CargarListasDePacientesDeLaBD()
        {
            this.miClinica.ListaPacientes = PacienteDAO.Listar();
            this.miClinica.ListaEspecialistas = EspecialistaDAO.Listar();
        }
        public void CargarListBoxDesdeBDYArchivosXml()
        {
            //Auxiliar que guarda los pacientes de otra clínica.
            List<Paciente> lstPacientes2da = Clinica.LeerPacientesXML(this.pathPacientesSegundaClinica);

            //Agrego a la lista ya existente de pacientes la nueva lista que viene del XML.
            foreach (Paciente item in lstPacientes2da)
            {
                this.miClinica.ListaPacientes.Add(item);
            }

            List<Especialista> lstEspecialistas2da = Clinica.LeerEspecialistasXML(this.pathEspecialistasSegundaClinica);

            foreach (Especialista item in lstEspecialistas2da)
            {
                this.miClinica.ListaEspecialistas.Add(item);
            }

            //Se cargan los listBox.
            foreach (Paciente item in this.miClinica.ListaPacientes)
            {
                this.lstBoxPacientes.Items.Add(item.ToString());
            }

            foreach (Especialista item in this.miClinica.ListaEspecialistas)
            {
                this.lstBoxEspecialistas.Items.Add(item.ToString());
            }
        }
        #endregion


        #region Métodos para mostrar por MessageBox 
        public void MostrarMsgException(Exception e)
        {
            MessageBox.Show(e.Message, "EXCEPCION CONTROLADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MostrarError(string datoDelError)
        {
            MessageBox.Show(datoDelError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Métodos de los botones

        #endregion

        private void btnLog_Click(object sender, EventArgs e)
        {
            FormLog auxMostrar = new FormLog();
            string nombreForm = "LOG";
            auxMostrar.Text = string.Format("{0,55}", nombreForm);

            try
            {
                auxMostrar.RtbLog.Text = GyLString.Leer(GyLString.pathLog);
                auxMostrar.ShowDialog();
            }
            catch (ArchivosException aEx)
            {
                this.MostrarMsgException(aEx);
                GyLString.Guardar(aEx.Message + GyLString.fechaLog, GyLString.pathLog);
            }
            catch (Exception ex)
            {
                this.MostrarError(ex.Message + "\n               CREANDO...");
                GyLString.Guardar(ex.Message + GyLString.fechaLog, GyLString.pathLog);
            }
        }

        #region JEJEJE de yapa para cambiar de color cuando seleccionas los ListBox
        private void lstBoxPacientes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(40, 102, 143));
            {
                e.DrawBackground();
                e.Graphics.DrawString(this.lstBoxPacientes.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
        }
        private void lstBoxEspecialistas_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(40, 102, 143));
            {
                e.DrawBackground();
                e.Graphics.DrawString(this.lstBoxEspecialistas.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
        }
        #endregion


    }
}
