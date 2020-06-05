using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////////////////////////////////
using System.Data.SqlClient;
////////////////////////////////

namespace PrimerEjercicioSQL
{
    public partial class FormPrincipal : Form
    {
        string connectionSTR;
        SqlConnection miConexion;       // Puente
        SqlCommand miComando;           // Quién lleva la consulta
        SqlDataReader oQueRecibeLaInfo; // Quién me trae los datos

        public FormPrincipal()
        {
            #region Parámetros de la conexión a la BD
            /*Data Source:
            - 1er param = (instancia del server a la que me quiero conectar)
            - 2do param = (a que bd me conecto)
            - 3er param = (que credenciales uso para conectarme(no tengo que usar UserName ni userPassword))
            */
            #endregion
            connectionSTR = @"Data Source = .\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;";

            miConexion = new SqlConnection(connectionSTR);
            miComando = new SqlCommand();

            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            string auxNombre = string.Empty;
            string auxApellido = string.Empty;
            string 

            // (a que server voy a realizar consultas? al server que se encuentra en miConexión.)
            miComando.Connection = miConexion; // unimos
            miComando.CommandType = CommandType.Text; // tipo de comando a ejecutar
            miComando.CommandText = "SELECT * FROM Alumnos";// le cargamos la query

            // Abro conexión (Siempre en un try catch)
            try
            {
                miConexion.Open();

                // Ejecuto
                oQueRecibeLaInfo = miComando.ExecuteReader();

                //MANEJAMOS DE A ROWS
                while (oQueRecibeLaInfo.Read())
                {
                    auxNombre = oQueRecibeLaInfo["nombre"].ToString(); // devuelve una tabla
                    auxApellido = oQueRecibeLaInfo["apellido"].ToString(); // devuelve una tabla
                }

            }
            catch (Exception ex)
            {
                // Escribir en un archivo de texto cuál es el error
                MessageBox.Show(ex.Message,
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                miConexion.Close();
            }



        }
    }
}
