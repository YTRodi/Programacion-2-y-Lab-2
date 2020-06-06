using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBDMicrosoft
{
    public partial class FormAgregarProducto : Form
    {
        Producto producto;
        Producto.EColores colores;
        public FormAgregarProducto()
        {
            InitializeComponent();
            //this.producto = new Producto(txtNombreProducto.Text, txtNumeroProducto.Text, colores);

        }
        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            cmboxColor.DataSource = Enum.GetValues(typeof(Producto.EColores));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.producto = new Producto(txtNombreProducto.Text, txtNumeroProducto.Text, colores);

            Enum.TryParse<Producto.EColores>(cmboxColor.SelectedValue.ToString(), out colores);
            //if(DAO.InsertarProducto(producto.nombreP, producto.numeroP, producto.colorP))
            if(DAO.InsertarProducto(producto.nombreP, producto.numeroP, producto.colorP))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
