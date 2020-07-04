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
using Formularios.FormsInformativos;

namespace Formularios
{
    public partial class FormMenuClinica : Form
    {
        #region Delegados y eventos para conectar información entre formularios.
        /// <summary>
        /// Delegado que tiene como función recibir un objeto y no retornar nada.
        /// </summary>
        /// <param name="obj">Pone lo que quieras papu, todo hereda de object.</param>
        public delegate void DelegadoParaPasarTurnos(object obj);

        /// <summary>
        /// Evento que se invocará cuando cambie el estado del turno a "EnEspera".
        /// </summary>
        public event DelegadoParaPasarTurnos EventoActualizarLstBoxEnEspera;

        /// <summary>
        /// Evento que se invocará cuando cambie el estado del turno a "Atendiendo".
        /// </summary>
        public event DelegadoParaPasarTurnos EventoActualizarLstBoxAtendiendo;
        #endregion

        #region Delegados y eventos para limpiar ListBox de otros formularios.
        /// <summary>
        /// Delegado que tiene como función recibir nada y no retornar nada.
        /// </summary>
        public delegate void DelegadoParaLimpiarListBox();

        /// <summary>
        /// Evento que se invocará cuando se quiera limpiar el listBox del formulario "FormSalaEspera"
        /// </summary>
        public event DelegadoParaLimpiarListBox EventoLimpiarListBoxEnEspera;

        /// <summary>
        /// Evento que se invocará cuando se quiera limpiar el listBox del formulario "FormAtendiendo"
        /// </summary>
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
        #endregion

        /// <summary>
        /// Constructor por defecto del formulario FormMenuClinica
        /// </summary>
        public FormMenuClinica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento Load que:
        /// 
        /// Primero: Instanciará la clínica y le pondrá nombre.
        /// 
        /// Segundo: Se cargarán las lista de pacientes y especialistas que se encuentran en la BD.
        /// 
        /// Tercero: Se cargarán las listas de paciente y especialistas que se encuentran en los archivo .xml de la segunda clínica.
        /// 
        /// NOTA: 
        /// Cada vez que ocurra una excepción, se guardará ese registro en el archivo log.txt (Se ubicará en el escritorio de la máquina).
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuClinica_Load(object sender, EventArgs e)
        {
            try
            {
                this.miClinica = new Clinica("Clínica Calchaquí");
                this.Text = string.Format("{0,150}", this.miClinica.RazonSocial);

                this.CargarListasDePacientesYEspecialistasDeLaBD();
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

        /// <summary>
        /// Manejador del evento FormClosing que Finaliza todos los hilos de la clinica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuClinica_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.miClinica.FinTurnos();
        }

        #region Botón de asignar turno y su métodos
        /// <summary>
        /// Manejador del evento Click que Se encargará de Asignar nuevos turnos.
        /// Informando cada vez que cambia de estado el turno.
        ///
        /// NOTA: 
        /// Cada vez que ocurra una excepción, se guardará ese registro en el archivo log.txt (Se ubicará en el escritorio de la máquina).
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                /*DESTILDAR PARA SACAR A LA BESTIA QUE GENERA TURNOS RANDOM !!!!.*/
                //this.lstBoxPacientes.SelectedIndex = this.rnd.Next(this.miClinica.ListaPacientes.Count);
                //this.lstBoxEspecialistas.SelectedIndex = this.rnd.Next(this.miClinica.ListaEspecialistas.Count);

                Turno nuevoTurno = new Turno(miClinica.ListaPacientes[lstBoxPacientes.SelectedIndex], miClinica.ListaEspecialistas[lstBoxEspecialistas.SelectedIndex], arrayObservaciones[this.rnd.Next(0, 11)], DateTime.Now);

                //Asigno al evento de la clase Turno un manejador llamado "turno_InformaEstado"
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

        /// <summary>
        /// Método Actualizará los estados del Turno.
        /// 
        /// Si está en el hilo principal, llama recursivamente al mismo método 
        /// para luego poder ejecutar el método ActualizarListBoxDeTurnos().
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void turno_InformaEstado(object obj)
        {
            //Esto es para acceder al hilo principal y poder modificar el control.
            if (this.InvokeRequired)
            {
                Turno.DelegadoTurnoEstado dte = new Turno.DelegadoTurnoEstado(this.turno_InformaEstado);

                Object[] arrayObj = new object[] { obj };

                this.Invoke(dte, arrayObj);
            }
            else
            {
                this.ActualizarListBoxDeTurnos();
            }
        }

        /// <summary>
        /// Método que actualiza los listBox de los formularios:
        ///  FormEnEspera y FormAtendiendo.
        /// </summary>
        private void ActualizarListBoxDeTurnos()
        {
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
                }
            }
        }
        #endregion

        #region Métodos que cargan las listas (Desde la base de datos y los archivos XML)
        /// <summary>
        /// Método que trae desde la base de datos a los pacientes y a los especialistas de la primera clínica.
        /// </summary>
        public void CargarListasDePacientesYEspecialistasDeLaBD()
        {
            this.miClinica.ListaPacientes = PacienteDAO.Listar();
            this.miClinica.ListaEspecialistas = EspecialistaDAO.Listar();
        }

        /// <summary>
        /// Método que carga las listas de pacientes y especialistas que se encuentran en los archivo .xml de la segunda clínica.
        /// 
        /// Luego cargará las lista de pacientes y especialistas.
        /// </summary>
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
        /// <summary>
        /// Método que mostrará el mensaje de la expcíón pasada por parámetro.
        /// </summary>
        /// <param name="e"></param>
        public void MostrarMsgException(Exception e)
        {
            MessageBox.Show(e.Message, "EXCEPCION CONTROLADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Método que mostrará el mensaje del string pasado por parámetro.
        /// </summary>
        /// <param name="datoDelError"></param>
        public void MostrarError(string datoDelError)
        {
            MessageBox.Show(datoDelError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Métodos de los botones
        /// <summary>
        /// Manejador del evento Click que Mostrará en una ventana de forma modal 
        /// el contenido del archivo de texto "log.txt".
        /// 
        /// Caso contrario de no existir este archivo, lo crea con un contenido.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        #region Botones ABM (Paciente y Especialistas)
        /* 
         * True = es un paciente
         * False = es un especialista
         */

        /// <summary>
        /// Manejador del evento Click que:
        /// 
        /// Primero: Instancia un formulario del tipo "FormPreABM".
        /// 
        /// Segundo: Abre el formulario en forma modal, con 3 opciones.
        /// 
        /// NOTA: (FLAG PARA REUTILIZAR FORMULARIOS.)
        /// 
        ///  En el constructor del FormPreABM: 
        ///  -Se le pasa "true": si se quiere invocar alguno de los formularios (alta, editar o eliminar) para el/los paciente/s.
        ///  -Se le pasa "false": si se quiere invocar alguno de los formularios (alta, editar o eliminar) para el/los especialista/s.
        ///  
        /// En caso de que se produzca un excepción se guardará en el log.txt.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnABMPaciente_Click(object sender, EventArgs e)
        {
            FormPreABM frmABM = new FormPreABM(this.miClinica, true);
            if (frmABM.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Operación realiza con éxito.",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                /*Actualizar lstBox*/
                this.lstBoxPacientes.Items.Clear();
                this.lstBoxEspecialistas.Items.Clear();
                this.CargarListasDePacientesYEspecialistasDeLaBD();
                this.CargarListBoxDesdeBDYArchivosXml();
            }
            else if (frmABM.DialogResult == DialogResult.Cancel)
            {
                //No muestro ni hago nada, porque canceló la operación que iba a hacer. (Mi regla de negocio.)
            }
            else
            {
                this.MostrarError("ERROR: no se pudo realizar su tarea (ABM paciente).");
                GyLString.Guardar("ERROR: no se pudo realizar su tarea (ABM paciente)." + GyLString.fechaLog, GyLString.pathLog);
            }
        }

        /// <summary>
        /// Manejador del evento Click que:
        /// 
        /// Primero: Instancia un formulario del tipo "FormPreABM".
        /// 
        /// Segundo: Abre el formulario en forma modal, con 3 opciones.
        /// 
        /// NOTA: (FLAG PARA REUTILIZAR FORMULARIOS.)
        /// 
        ///  En el constructor del FormPreABM: 
        ///  -Se le pasa "true": si se quiere invocar alguno de los formularios (alta, editar o eliminar) para el/los paciente/s.
        ///  -Se le pasa "false": si se quiere invocar alguno de los formularios (alta, editar o eliminar) para el/los especialista/s.
        ///  
        /// En caso de que se produzca un excepción se guardará en el log.txt.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnABMEspecialista_Click(object sender, EventArgs e)
        {
            FormPreABM frmABM = new FormPreABM(this.miClinica, false);
            if (frmABM.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Operación realiza con éxito.",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                /*Actualizar lstBox*/
                this.lstBoxPacientes.Items.Clear();
                this.lstBoxEspecialistas.Items.Clear();
                this.CargarListasDePacientesYEspecialistasDeLaBD();
                this.CargarListBoxDesdeBDYArchivosXml();
            }
            else if (frmABM.DialogResult == DialogResult.Cancel)
            {
                //No muestro nada, pq canceló la operación que iba a hacer.
            }
            else
            {
                this.MostrarError("ERROR: no se pudo realizar su tarea (ABM paciente).");
                GyLString.Guardar("ERROR: no se pudo realizar su tarea (ABM paciente)." + GyLString.fechaLog, GyLString.pathLog);
            }
        }
        #endregion
        #endregion

    }
}
