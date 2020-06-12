using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEnWinForms
{
    public partial class FrmMostrar : Form
    {
        #region Delegado para manejar actualizaciones de strings
        public delegate void DlgActualizarString(string dato);
        #endregion

        public FrmMostrar()
        {
            InitializeComponent();
        }
        public void ActualizarNombre(string dato)
        {
            this.lblEtiqueta.Text = dato;
        }
    }
}
