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
    public partial class FormAtendiendo : Form
    {
        public FormAtendiendo()
        {
            InitializeComponent();
        }

        public void ActualizarListBoxAtendiendo(object obj)
        {
            this.lsbBoxAtendiendo.Items.Add(((Turno)obj).MostrarTurnoAtendiendo());
        }

        public void LimpiarListBoxAtendiendo()
        {
            this.lsbBoxAtendiendo.Items.Clear();
        }
    }
}
