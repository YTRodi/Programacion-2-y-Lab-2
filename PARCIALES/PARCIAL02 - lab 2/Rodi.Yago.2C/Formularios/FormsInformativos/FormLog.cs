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
    public partial class FormLog : Form
    {
        /// <summary>
        /// Constructor por defecto del formulario FormAlta que inicializa:
        /// </summary>
        public FormLog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el control richTextBox de este formulario.
        /// </summary>
        public RichTextBox RtbLog
        {
            get { return this.rtbMostrarLog; }
            set { this.rtbMostrarLog = value; }
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
    }
}
