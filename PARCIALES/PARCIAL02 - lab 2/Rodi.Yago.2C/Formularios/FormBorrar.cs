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
    public partial class FormBorrar : Form
    {
        Clinica clinicaActual;
        Paciente nuevoPaciente;
        bool esPaciente = false;

        /// <summary>
        /// Constructor por defecto del formulario FormBorrar que inicializa:
        /// 
        /// </summary>
        /// <param name="cli"></param>
        /// <param name="esPaciente"></param>
        public FormBorrar(Clinica cli, bool esPaciente)
        {
            InitializeComponent();
            this.clinicaActual = cli;
            this.esPaciente = esPaciente;
        }

        /// <summary>
        /// Manejador del evento Click que Cierra este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    this.lstBoxEliminar.Items.Add(item);
                }
            }
            else
            {
                foreach (Especialista item in this.clinicaActual.ListaEspecialistas)
                {
                    this.lstBoxEliminar.Items.Add(item);
                }
            }
            
        }

        /// <summary>
        /// Manejador del evento Click en el cuál se intentará eliminar al paciente o especialista
        /// (Siempre basandonos en el atrubto "esPaciente").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string apellido = string.Empty;
            string nombre = string.Empty;

            if (this.esPaciente)
            {
                id = this.clinicaActual.ListaPacientes[lstBoxEliminar.SelectedIndex].Id;

                apellido = this.clinicaActual.ListaPacientes[lstBoxEliminar.SelectedIndex].Apellido;
                nombre = this.clinicaActual.ListaPacientes[lstBoxEliminar.SelectedIndex].Nombre;

                if (MessageBox.Show($"¿Está seguro que desea eliminar al paciente {apellido} {nombre}?", "Notificación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!(id >= 900 && id <= 1899))//Si es de mi clínica, lo elimino, sino no hago nada.
                    {
                        if (PacienteDAO.Delete(id))
                        {
                            this.DialogResult = DialogResult.OK;
                            GyLString.Guardar($"Se eliminó el paciente con ID: {id}." + GyLString.fechaLog, GyLString.pathLog);

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
            else
            {
                id = this.clinicaActual.ListaEspecialistas[lstBoxEliminar.SelectedIndex].Id;

                apellido = this.clinicaActual.ListaEspecialistas[lstBoxEliminar.SelectedIndex].Apellido;
                nombre = this.clinicaActual.ListaEspecialistas[lstBoxEliminar.SelectedIndex].Nombre;

                if (MessageBox.Show($"¿Está seguro que desea eliminar al especialista {apellido} {nombre}?", "Notificación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!(id >= 1500 && id <= 1519))//Si es de mi clínica, lo elimino, sino no hago nada.
                    {
                        if (EspecialistaDAO.Delete(id))
                        {
                            this.DialogResult = DialogResult.OK;
                            GyLString.Guardar($"Se eliminó el especialista con ID: {id}." + GyLString.fechaLog, GyLString.pathLog);
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
            this.lblEliminar.Text = "Eliminar Especialista";
            this.lblSeleccion.Text = "Seleccione el especialista a eliminar";
        }
    }
}
