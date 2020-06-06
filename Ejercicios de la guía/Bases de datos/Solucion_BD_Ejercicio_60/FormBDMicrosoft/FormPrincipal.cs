using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;

namespace FormBDMicrosoft
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //properties DGRID
            dGridProducts.ReadOnly = true;
            dGridProducts.RowHeadersVisible = false;
            dGridProducts.GridColor = Color.DarkSlateBlue;
            dGridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                dGridProducts.DataSource = DAO.ListarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message,
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //hacer que abra el formulario para agregar...
            FormAgregarProducto frm_AgregarProduct = new FormAgregarProducto();

            if (frm_AgregarProduct.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                frm_AgregarProduct.Hide();
            }
        }
    }
}
