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

namespace FormCantina
{
    public partial class FrmBar : Form
    {
        private Edificio tower;
        private FrmCantidadEspaciosCantina cantidadEspacios;


        public FrmBar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //-----QUITO ESTO PARA PODER USAR LA CANTIDAD ESTA EN EL EVENTO CLICK DE BARRAS//---------------------
            //FrmCantidadEspaciosCantina cantidadEspacios = new FrmCantidadEspaciosCantina();
             cantidadEspacios = new FrmCantidadEspaciosCantina();

            cantidadEspacios.ShowDialog();
            if(cantidadEspacios.DialogResult == DialogResult.OK)//si retorna OK como respuesta, osea aceptar.
            {
                //Consulto la cantidad de espacios que se cargó en FrmCantidadEspaciosCantina.
                //Instancio un nuevo formCantina.

                FormCantina frm_Cantina = new FormCantina(cantidadEspacios.CantidadEspacios);
                if (this.tower + frm_Cantina.GetCantina)
                {
                    //el frm_Cantina va a ser contenedor del frmBar
                    frm_Cantina.MdiParent = this;//establece el formulario MDI principal actual de este formulario.
                    frm_Cantina.Show();
                }
                else
                {
                   MessageBox.Show("Solamente pueden agregarse 2 barras en este edificio.",
                       "ERROR",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

            }
        }

        private void FrmBar_Load(object sender, EventArgs e)
        {
            //frm_Cantina = new FormCantina();
            tower = Edificio.GetBar();
        }

        private void btnBarras_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Cantina aux = new Cantina(cantidadEspacios.CantidadEspacios);
            
            foreach (FormCantina item in this.MdiChildren)
            {
                MessageBox.Show(item.GetInforme,
                    "DATOS DE LAS BEBIDAS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
