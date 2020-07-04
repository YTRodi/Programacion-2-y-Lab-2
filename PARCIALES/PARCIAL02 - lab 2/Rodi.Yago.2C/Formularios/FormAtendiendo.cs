using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Instanciables;
using Entidades_Instanciables.Bases_de_datos;
using WindowsFormsApp.FormsInformativos;

namespace Formularios
{
    public partial class FormAtendiendo : Form
    {
        List<Turno> lstTurnos;

        /// <summary>
        /// Constructor por defecto del formulario FormAtendiendo que inicializa:
        ///  Una lista de turnos.
        /// </summary>
        /// <param name="lstTurnos"></param>
        public FormAtendiendo(List<Turno> lstTurnos)
        {
            InitializeComponent();
            this.lstTurnos = lstTurnos;
        }

        /// <summary>
        /// Método que actualiza el listBox "lsbBoxAtendiendo" cuando el estado del turno es "Atendiendo"
        /// mostrando en su contenido un mensaje en específico de los detalles del turno.
        /// </summary>
        /// <param name="obj"></param>
        public void ActualizarListBoxAtendiendo(object obj)
        {
            this.lsbBoxAtendiendo.Items.Add(((Turno)obj).MostrarTurnoAtendiendo());
        }

        /// <summary>
        /// Método que limpia el listBox "lstBoxEspera".
        /// </summary>
        public void LimpiarListBoxAtendiendo()
        {
            this.lsbBoxAtendiendo.Items.Clear();
        }

        /// <summary>
        /// Manejador del evento Click que instancia un formulario del tipo "FormTurnosFinalizados" y se le pasa
        /// por parámetro la lista, para mostrar en un listBox los turnos que fueron finalizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTurnosFinalizados_Click(object sender, EventArgs e)
        {
            FormTurnosFinalizados frmTurnosFinalizados = new FormTurnosFinalizados(TurnoDAO.ListarTurnos());
            frmTurnosFinalizados.LblTotal.Text = "Total: " + frmTurnosFinalizados.TurnosFinalizados.Count;
            frmTurnosFinalizados.ShowDialog();
        }
    }
}
