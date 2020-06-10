using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormPrincipal : Form
    {
        private List<Electrodomestico> lstElectro;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.lstElectro = new List<Electrodomestico>();
        }
    }
}
