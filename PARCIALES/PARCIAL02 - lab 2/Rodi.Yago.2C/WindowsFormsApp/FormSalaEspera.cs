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

namespace WindowsFormsApp
{
    public partial class FormSalaEspera : Form
    {
        public FormSalaEspera()
        {
            InitializeComponent();
        }

        public void ActualizarListBoxEnEspera(object obj)
        {
            this.lstBoxEspera.Items.Add(((Turno)obj).MostrarTurnoSalaEspera());
        }

        public void LimpiarListBoxEspera()
        {
            this.lstBoxEspera.Items.Clear();
        }
    }
}
