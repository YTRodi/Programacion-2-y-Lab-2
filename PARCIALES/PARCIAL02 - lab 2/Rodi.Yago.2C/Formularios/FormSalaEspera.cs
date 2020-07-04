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

namespace Formularios
{
    public partial class FormSalaEspera : Form
    {
        /// <summary>
        /// Constructor por defecto del formulario FormSalaEspera
        /// </summary>
        public FormSalaEspera()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que actualiza el listBox "lstBoxEspera" cuando el estado del turno es "EnEspera"
        /// mostrando en su contenido un mensaje en específico de los detalles del turno.
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void ActualizarListBoxEnEspera(object obj)
        {
            this.lstBoxEspera.Items.Add(((Turno)obj).MostrarTurnoSalaEspera());
        }

        /// <summary>
        /// Método que limpia el listBox "lstBoxEspera".
        /// </summary>
        public void LimpiarListBoxEspera()
        {
            this.lstBoxEspera.Items.Clear();
        }
    }
}
