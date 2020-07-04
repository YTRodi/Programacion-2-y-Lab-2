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
    public partial class FormAlta : Form
    {
        Clinica clinicaActual;
        Paciente nuevoPaciente;
        Especialista nuevoEspecialista;
        bool esPaciente = false;

        /// <summary>
        /// Constructor por defecto del formulario FormAlta que inicializa:
        /// el comboBox de sexo, el comboBox de obraSocial o Campo del especialista (Llamado así para reutilizar).
        /// </summary>
        /// <param name="cli"></param>
        /// <param name="esPaciente"></param>
        public FormAlta(Clinica cli, bool esPaciente)
        {
            InitializeComponent();
            this.clinicaActual = cli;
            cmbSexo.DataSource = Enum.GetValues(typeof(Persona.ESexo));
            cmbObraCampo.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));

            this.esPaciente = esPaciente;
        }

        /// <summary>
        /// Manejador del evento Click que:
        /// Verifica si:
        ///     El atributo esPaciente es true: Intentará Insertar en al base de datos al nuevo Paciente.
        ///     Si el atributo es false: Intentará insertar en la base de atos al nuevo Especialista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona.ESexo sexoP;
            Enum.TryParse<Persona.ESexo>(cmbSexo.SelectedValue.ToString(), out sexoP);

            if (this.esPaciente)
            {
                //Igual a centralita.
                Paciente.EObraSocial obraSocialP;

                Enum.TryParse<Paciente.EObraSocial>(cmbObraCampo.SelectedValue.ToString(), out obraSocialP);

                if (txtBoxNombre.Text != string.Empty &&
                   txtBoxApellido.Text != string.Empty &&
                   txtBoxDni.Text != string.Empty &&
                   txtBoxDireccion.Text != string.Empty &&
                   txtBoxDni.Text != string.Empty)
                {
                    //Ya que no se permite ninguno de estos campos NULL en la base de datos.
                    this.nuevoPaciente = new Paciente(txtBoxApellido.Text, txtBoxNombre.Text, Convert.ToInt32(txtBoxEdad.Text), sexoP, txtBoxDireccion.Text, Convert.ToInt32(txtBoxDni.Text), obraSocialP);

                    if (!(this.nuevoPaciente is null))
                    {
                        this.clinicaActual += this.nuevoPaciente;
                        /*Agrego a base de datos*/
                        if (PacienteDAO.Insertar(this.nuevoPaciente))
                        {
                            this.DialogResult = DialogResult.OK;
                            GyLString.Guardar($"Se agregó el paciente {this.nuevoPaciente.Apellido} {this.nuevoPaciente.Nombre} a la {this.clinicaActual.RazonSocial}." + GyLString.fechaLog, GyLString.pathLog);
                        }
                        else
                            this.DialogResult = DialogResult.Abort;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else//Es especialista.
            {
                Especialista.EEspecialidad especialidad;
                Enum.TryParse<Especialista.EEspecialidad>(cmbObraCampo.SelectedValue.ToString(), out especialidad);

                if (txtBoxNombre.Text != string.Empty &&
                   txtBoxApellido.Text != string.Empty &&
                   txtBoxDni.Text != string.Empty &&
                   txtBoxDireccion.Text != string.Empty &&
                   txtBoxDni.Text != string.Empty)
                {
                    //Ya que no se permite ninguno de estos campos NULL en la base de datos.
                    this.nuevoEspecialista = new Especialista(txtBoxApellido.Text, txtBoxNombre.Text, Convert.ToInt32(txtBoxEdad.Text), sexoP, txtBoxDireccion.Text, Convert.ToInt32(txtBoxDni.Text), especialidad);

                    if (!(this.nuevoEspecialista is null))
                    {
                        this.clinicaActual += this.nuevoEspecialista;
                        /*Agrego a base de datos*/
                        if (EspecialistaDAO.Insertar(this.nuevoEspecialista))
                        {
                            this.DialogResult = DialogResult.OK;
                            GyLString.Guardar($"Se agregó el especialista {this.nuevoEspecialista.Apellido} {this.nuevoEspecialista.Nombre} a la {this.clinicaActual.RazonSocial}." + GyLString.fechaLog, GyLString.pathLog);
                        }
                        else
                            this.DialogResult = DialogResult.Abort;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
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
            this.lblAlta.Text = "Alta Especialista";
            this.lblObraCampo.Text = "Campo";
            this.cmbObraCampo.DataSource = Enum.GetValues(typeof(Especialista.EEspecialidad));
        }
    }
}
