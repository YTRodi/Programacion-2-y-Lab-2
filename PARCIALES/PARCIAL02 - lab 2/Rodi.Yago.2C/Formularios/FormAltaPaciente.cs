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

namespace Formularios
{
    public partial class FormAltaPaciente : Form
    {
        Clinica clinicaActual;
        Paciente nuevoPaciente;
        

        public FormAltaPaciente(Clinica cli)
        {
            InitializeComponent();
            this.clinicaActual = cli;
            cmbSexo.DataSource = Enum.GetValues(typeof(Persona.ESexo));
            cmbObraCampo.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Igual a centralita.
            Persona.ESexo sexoP;
            Paciente.EObraSocial obraSocialP;

            Enum.TryParse<Persona.ESexo>(cmbSexo.SelectedValue.ToString(), out sexoP);
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
                    PacienteDAO.Insertar(this.nuevoPaciente);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
