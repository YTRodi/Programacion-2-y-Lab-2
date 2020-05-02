using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCantina
{
    public partial class FrmCantidadEspaciosCantina : Form
    {
        #region Properties
        public int CantidadEspacios//LA HICE ESTATICA ASI PUEDO USARLA EN EL FORMCANTINA Y SETEAR LA CANTIDAD DE ESPACIOS.
        {
            get
            {
                int aux = Convert.ToInt32(numUDCantidad.Value);
                return aux;
            }
            set
            {
                this.numUDCantidad.Value = value;
            }
        }
        #endregion

        public FrmCantidadEspaciosCantina()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
