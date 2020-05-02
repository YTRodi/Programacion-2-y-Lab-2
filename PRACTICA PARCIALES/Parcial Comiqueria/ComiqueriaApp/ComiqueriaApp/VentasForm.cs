using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        #region Atributos
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;
        #endregion

        #region Constructores
        public VentasForm()
        {
            InitializeComponent();
        }

        public VentasForm(Comiqueria comiqueria, Producto producto) : this()
        {
            this.comiqueria = comiqueria;
            this.productoSeleccionado = producto;
        }
        #endregion


        #region Métodos propios
        public void PrecioActualizado()
        {
            //guardo el valor que viene del numericUpDownCantidad
            int cantidadSeleccionada = Convert.ToInt32(numericUpDownCantidad.Value);

            //guardo el resultado del nuevo precio final (método CalcularPrecioFinal de la clase Ventas)
            double resultadoNuevoPrecioFinal = Venta.CalcularPrecioFinal(this.productoSeleccionado.Precio, cantidadSeleccionada);

            //Cada que la cantidad aumente, el precio final debe actualizarse.
            lblPrecioFinal.Text = string.Format("Precio Final: ${0:0.00}", resultadoNuevoPrecioFinal);
        }
        #endregion

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = productoSeleccionado.Descripcion;
            this.PrecioActualizado();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.PrecioActualizado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionada = Convert.ToInt32(numericUpDownCantidad.Value);
            if(cantidadSeleccionada <= productoSeleccionado.Stock)
            {
                //Genero una nueva venta.
                this.comiqueria.Vender(productoSeleccionado, cantidadSeleccionada);
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usted superó el stock disponible",
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
