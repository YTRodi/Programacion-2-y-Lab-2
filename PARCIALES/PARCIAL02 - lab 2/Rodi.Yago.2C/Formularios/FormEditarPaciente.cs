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
    public partial class FormEditarPaciente : Form
    {
        Clinica clinicaActual;
        Paciente nuevoPaciente;

        public FormEditarPaciente(Clinica cli)
        {
            InitializeComponent();
            this.clinicaActual = cli;
            cmbSexo.DataSource = Enum.GetValues(typeof(Persona.ESexo));
            cmbObraCampo.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));
        }

        private void FormEditarPaciente_Load(object sender, EventArgs e)
        {
            foreach (Paciente item in this.clinicaActual.ListaPacientes)
            {
                this.lstBoxPacientesEditar.Items.Add(item);
            }
        }

        private void lstBoxPacientesEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBoxNombre.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Nombre;
            this.txtBoxApellido.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Apellido;
            this.txtBoxEdad.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Edad.ToString();
            this.cmbSexo.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Sexo.ToString();
            this.txtBoxDireccion.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Direccion;
            this.txtBoxDni.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].DNI.ToString();
            this.cmbObraCampo.Text = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].ObraSocial.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = this.clinicaActual.ListaPacientes[lstBoxPacientesEditar.SelectedIndex].Id;
            string nombre = this.txtBoxApellido.Text;
            string apellido = this.txtBoxNombre.Text;
            int edad = Convert.ToInt32(this.txtBoxEdad.Text);
            string sexo = cmbSexo.Text;
            string direccion = this.txtBoxDireccion.Text;
            string obraSocial = this.cmbObraCampo.Text;
            int dni = Convert.ToInt32(this.txtBoxDni.Text);


            if (!(id >= 900 && id <= 1899))//Si es de mi clínica, lo edito, sino no hago nada.
            {
                if (nombre != string.Empty &&
                    apellido != string.Empty &&
                    edad != 0 &&
                    direccion != string.Empty &&
                    dni != 0)
                {
                    if (PacienteDAO.Update(id, apellido, nombre, edad, sexo, direccion, obraSocial, dni))
                    {
                        this.DialogResult = DialogResult.OK;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
