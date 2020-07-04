using Entidades_Instanciables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.FormsInformativos
{
    public partial class FormPreABM : Form
    {
        Clinica clinicaActual;
        bool esPaciente = false;

        /// <summary>
        /// Constructor por defecto que inicializa la clínica y el atributo esPaciente.
        /// </summary>
        /// <param name="cli"></param>
        /// <param name="esPaciente">Para reutilizar fomrularios de alta, baja y modificación.</param>
        public FormPreABM(Clinica cli, bool esPaciente)
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
        /// Manejador del evento Click en el cuál:
        ///    Si el atributo "esPaciente" es:
        ///    TRUE: Se abrirá el FormAlta para el paciente nuevo.
        ///    False: Se abrirá el FormAlta para el especilista nuevo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAlta frmAlta = new FormAlta(this.clinicaActual, this.esPaciente);
            if(this.esPaciente)
            {
                if (frmAlta.ShowDialog() == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
                else if (frmAlta.DialogResult == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Cancel;
                else
                    this.DialogResult = DialogResult.Abort;
            }
            else
            {
                /*Seteo los campos para el especialista*/
                frmAlta.SetCamposParaEspecialista();

                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else if (frmAlta.DialogResult == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Cancel;
                else
                    this.DialogResult = DialogResult.Abort;
            }
        }

        /// <summary>
        /// Manejador del evento Click en el cuál:
        ///    Si el atributo "esPaciente" es:
        ///    TRUE: Se abrirá el FormAlta para el paciente a editar.
        ///    False: Se abrirá el FormAlta para el especilista a editar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar frmEditar = new FormEditar(this.clinicaActual,this.esPaciente);
            if (this.esPaciente)
            {
                if (frmEditar.ShowDialog() == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
                else if (frmEditar.DialogResult == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Cancel;
                else
                    this.DialogResult = DialogResult.Abort;
            }
            else
            {
                frmEditar.SetCamposParaEspecialista();

                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else if (frmEditar.DialogResult == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Cancel;
                else
                    this.DialogResult = DialogResult.Abort;
            }
                
        }

        /// <summary>
        /// Manejador del evento Click en el cuál:
        ///    Si el atributo "esPaciente" es:
        ///    TRUE: Se abrirá el FormAlta para el paciente a eliminar.
        ///    False: Se abrirá el FormAlta para el especilista a eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormBorrar frmBorrar = new FormBorrar(this.clinicaActual, this.esPaciente);
            if(this.esPaciente)
            {
                if (frmBorrar.ShowDialog() == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
                else if (frmBorrar.DialogResult == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Cancel;
                else
                    this.DialogResult = DialogResult.Abort;
            }
            else
            {
                frmBorrar.SetCamposParaEspecialista();

                if (frmBorrar.ShowDialog() == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
                else if (frmBorrar.DialogResult == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Cancel;
                else
                    this.DialogResult = DialogResult.Abort;
            }
            
        }
    }
}
