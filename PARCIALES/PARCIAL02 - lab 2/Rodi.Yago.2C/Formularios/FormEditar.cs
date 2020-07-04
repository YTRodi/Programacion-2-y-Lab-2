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
using Métodos_de_extensión;

namespace Formularios
{
    public partial class FormEditar : Form
    {
        Clinica clinicaActual;
        bool esPaciente = false;

        /// <summary>
        /// Constructor por defecto del formulario FormAlta que inicializa:
        /// el comboBox de sexo, el comboBox de obraSocial o Campo del especialista (Llamado así para reutilizar).
        /// </summary>
        /// <param name="cli"></param>
        /// <param name="esPaciente"></param>
        public FormEditar(Clinica cli, bool esPaciente)
        {
            InitializeComponent();
            this.clinicaActual = cli;
            cmbSexo.DataSource = Enum.GetValues(typeof(Persona.ESexo));
            cmbObraCampo.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));
            this.esPaciente = esPaciente;
        }

        /// <summary>
        /// Manejador del evento Load que cargará los listBox con los Pacientes o Especialistas de la clínica
        /// (Uso como flag al atributo "esPaciente")
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditarPaciente_Load(object sender, EventArgs e)
        {
            if(this.esPaciente)
            {
                foreach (Paciente item in this.clinicaActual.ListaPacientes)
                {
                    this.lstBoxEditar.Items.Add(item);
                }
            }
            else
            {
                foreach (Especialista item in this.clinicaActual.ListaEspecialistas)
                {
                    this.lstBoxEditar.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Manejador del evento SelectedIndexChanged que lo que hará, será 
        /// mostrar en cada control, los datos del Paciente o Especialista seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxPacientesEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.esPaciente)
            {
                this.txtBoxNombre.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].Nombre;
                this.txtBoxApellido.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].Apellido;
                this.txtBoxEdad.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].Edad.ToString();
                this.cmbSexo.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].Sexo.ToString();
                this.txtBoxDireccion.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].Direccion;
                this.txtBoxDni.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].DNI.ToString();
                this.cmbObraCampo.Text = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].ObraSocial.ToString();
            }
            else
            {
                this.txtBoxNombre.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Nombre;
                this.txtBoxApellido.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Apellido;
                this.txtBoxEdad.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Edad.ToString();
                this.cmbSexo.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Sexo.ToString();
                this.txtBoxDireccion.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Direccion;
                this.txtBoxDni.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].DNI.ToString();
                this.cmbObraCampo.Text = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Campo.ToString();
            }
        }

        /// <summary>
        /// Manejador del evento Click en el cuál se intentará editar al paciente o especialista
        /// (Siempre basandonos en el atrubto "esPaciente").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = 0;//= this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Id;
            string nombre = this.txtBoxApellido.Text;
            string apellido = this.txtBoxNombre.Text;
            int edad = Convert.ToInt32(this.txtBoxEdad.Text);
            string sexo = cmbSexo.Text;
            string direccion = this.txtBoxDireccion.Text;
            string obraSocialCampo = this.cmbObraCampo.Text;
            int dni = Convert.ToInt32(this.txtBoxDni.Text);

            if(this.esPaciente)
            {
                id = this.clinicaActual.ListaPacientes[lstBoxEditar.SelectedIndex].Id;

                if (!(id >= 900 && id <= 1899))//Si es de mi clínica, lo edito, sino no hago nada.
                {
                    if (nombre != string.Empty &&
                        apellido != string.Empty &&
                        edad != 0 &&
                        direccion != string.Empty &&
                        dni != 0)
                    {
                        if (PacienteDAO.Update(id, apellido, nombre, edad, sexo, direccion, obraSocialCampo, dni))
                        {
                            this.DialogResult = DialogResult.OK;
                            GyLString.Guardar($"Se editó el paciente con ID: {id}." + GyLString.fechaLog, GyLString.pathLog);
                        }
                        else
                            this.DialogResult = DialogResult.Abort;
                    }
                    else
                        this.DialogResult = DialogResult.Abort;
                }
                else
                    this.DialogResult = DialogResult.Abort;
            }
            else
            {
                id = this.clinicaActual.ListaEspecialistas[lstBoxEditar.SelectedIndex].Id;

                if (!(id >= 1500 && id <= 1519))//Si es de mi clínica, lo edito, sino no hago nada.
                {
                    if (nombre != string.Empty &&
                        apellido != string.Empty &&
                        edad != 0 &&
                        direccion != string.Empty &&
                        dni != 0)
                    {
                        if (EspecialistaDAO.Update(id, apellido, nombre, edad, sexo, direccion, obraSocialCampo, dni))
                        {
                            this.DialogResult = DialogResult.OK;
                            GyLString.Guardar($"Se editó el especialista con ID: {id}." + GyLString.fechaLog, GyLString.pathLog);
                        }
                        else
                            this.DialogResult = DialogResult.Abort;
                    }
                    else
                        this.DialogResult = DialogResult.Abort;
                }
                else
                    this.DialogResult = DialogResult.Abort;


            }
        }

        /// <summary>
        /// Manejador del evento Click que Cierra este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Método que setea los campos en caso del que atributo "esPaciente" sea false.
        /// </summary>
        public void SetCamposParaEspecialista()
        {
            this.lblEditar.Text = "Editar Especialista";
            this.lblCampoObra.Text = "Campo";
            this.cmbObraCampo.DataSource = Enum.GetValues(typeof(Especialista.EEspecialidad));
            this.lblSeleccion.Text = "Seleccione el especialista a editar";
        }
    }
}
