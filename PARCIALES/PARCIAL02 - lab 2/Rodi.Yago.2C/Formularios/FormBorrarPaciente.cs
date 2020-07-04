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
    public partial class FormBorrarPaciente : Form
    {
        Clinica clinicaActual;
        Paciente nuevoPaciente;

        public FormBorrarPaciente(Clinica cli)
        {
            InitializeComponent();
            this.clinicaActual = cli;
        }

        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormEditarPaciente_Load(object sender, EventArgs e)
        {
            foreach (Paciente item in this.clinicaActual.ListaPacientes)
            {
                this.lstBoxPacientesEliminar.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = this.clinicaActual.ListaPacientes[lstBoxPacientesEliminar.SelectedIndex].Id;
            string apellido = this.clinicaActual.ListaPacientes[lstBoxPacientesEliminar.SelectedIndex].Apellido;
            string nombre = this.clinicaActual.ListaPacientes[lstBoxPacientesEliminar.SelectedIndex].Nombre;

            if(MessageBox.Show($"¿Está seguro que desea eliminar al paciente {apellido} {nombre}?","Notificación",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (!(id >= 900 && id <= 1899))//Si es de mi clínica, lo elimino, sino no hago nada.
                {
                    if (PacienteDAO.Delete(id))
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
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
