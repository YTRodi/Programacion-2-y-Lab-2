using Entidades_Instanciables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.FormsInformativos
{
    public partial class FormTurnosFinalizados : Form
    {
        List<Turno> lstTurnos;

        public List<Turno> TurnosFinalizados
        {
            get { return this.lstTurnos; }
            set { this.lstTurnos = value; }
        }



        public FormTurnosFinalizados(List<Turno> lstTurnos)
        {
            InitializeComponent();
            this.lstTurnos = lstTurnos;
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el control Label que está en este formulario.
        /// </summary>
        public Label LblTotal
        {
            get { return this.lblTotal; }
            set { this.lblTotal = value; }
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
        /// Manejador del evento Load que cargará el listBox "lstTurnosFinalizados" 
        /// los turnos que se encuentren en la bd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTurnosFinalizados_Load(object sender, EventArgs e)
        {
            foreach (Turno item in this.lstTurnos)
            {
                this.lstTurnosFinalizados.Items.Add(((Turno)item).MostrarTurnosFinalizados());
            }
        }
    }
}
