using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormPrincipal : Form
    {
        private List<Persona> lstPer;
        ////////////////////////////////////////////////////////////////////////////////////////////
        //           LOS TEXT BOX PONERLOS EN OTRO FORM Y REUTILIZAR FORMULARIOS!!!               //
        ////////////////////////////////////////////////////////////////////////////////////////////
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.lstPer = new List<Persona>();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarNombreApellido(txtNombre.Text, txtApellido.Text))
                {
                    Persona nuevaPersona = new Persona(txtNombre.Text, txtApellido.Text);
                    if(PersonaDAO.Guardar(nuevaPersona))
                    {
                        MsgSuccess("Persona agregada con éxito.");
                        LimpiarTxtBox();
                    }
                    
                    btnListar_Click(sender, e);
                }
                else
                    throw new Exception("El/Los campo/s no pueden quedar vacios.");
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                lstPer = PersonaDAO.Leer();
                ImprimirEnListBox();
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////
            //           LOS TEXT BOX PONERLOS EN OTRO FORM Y REUTILIZAR FORMULARIOS!!!               //
            ////////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                Persona personaAModificar = this.lstPer[lstPersonas.SelectedIndex];
                personaAModificar.Nombre = txtNombre.Text;
                personaAModificar.Apellido = txtApellido.Text;

                if (PersonaDAO.Modificar(personaAModificar))
                {
                    MsgSuccess("Se modificó a la persona con éxito.");
                    LimpiarTxtBox();
                    btnListar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////
            //           LOS TEXT BOX PONERLOS EN OTRO FORM Y REUTILIZAR FORMULARIOS!!!               //
            ////////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                Persona personaABorrar = this.lstPer[lstPersonas.SelectedIndex];

                if (PersonaDAO.Borrar(personaABorrar.ID))
                {
                    MsgSuccess("Se eliminó a la persona con éxito.");
                    btnListar_Click(sender, e);
                }
            }
            catch(ArgumentOutOfRangeException aEx)
            {
                MsgError("Ninguna persona fue seleccionada de la lista.");
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
        }

        private void btnLeerPorID_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////
            //                              PASARLO A OTRO FORM !!!!!!!!!!!!                          //
            ////////////////////////////////////////////////////////////////////////////////////////////
            Persona personaLeida = null;
            try
            {
                if (!(txtIDALeer.Text is ""))//HACER LA VALIDACION EN UN MÉTODO
                {
                    int idParseado = default(int);
                    int.TryParse(txtIDALeer.Text, out idParseado);

                    personaLeida = PersonaDAO.LeerPorID(idParseado);
                    ImprimirPersonaLeidaPorID(personaLeida);
                }
                else
                    MsgError("El campo no puede quedar vacio o no existe el el ID");
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }

        #region Methods
        public void LimpiarTxtBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }
        public void LimpiarListBox()
        {
            this.lstPersonas.Items.Clear();
        }
        public void ImprimirEnListBox()
        {
            LimpiarListBox();
            if (!(this.lstPer is null))
            {
                foreach (Persona item in this.lstPer)
                {
                    this.lstPersonas.Items.Add(item.ToString());
                }
            }
        }
        public void ImprimirPersonaLeidaPorID(Persona p)
        {
            LimpiarListBox();
            if (!(p is null))
                this.lstPersonas.Items.Add(p.ToString());
            else
                throw new Exception("No existe persona con ese ID o fue eliminado.");
        }

        public bool ValidarNombreApellido(string nombre, string apellido)
        {
            bool pasoValidación = false;
            Regex expresionRegular = new Regex("^[a-zA-ZÁÉÍÓÚáéíóú]*$");

            if (nombre != string.Empty && apellido != string.Empty)
                if (expresionRegular.IsMatch(nombre) && expresionRegular.IsMatch(apellido))
                    pasoValidación = true;

            return pasoValidación;
        }
        #endregion

        #region Messages
        public void MsgSuccess(string msgSuccess)
        {
            MessageBox.Show(msgSuccess, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MsgError(string msgError)
        {
            MessageBox.Show(msgError, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        #endregion

       
    }
}
