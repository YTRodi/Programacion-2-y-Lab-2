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

namespace DataGridEnSQL
{
    public partial class FormPrincipal : Form
    {
        string connectionSTR = @"Data Source = .\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;";
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader lector;

        DataTable miTabla;

        public FormPrincipal()
        {
            miConexion = new SqlConnection(connectionSTR);
            miComando = new SqlCommand();

            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            miTabla = new DataTable();

            //Properties dataGridView.
            dGridAlumnos.ReadOnly = true;
            dGridAlumnos.RowHeadersVisible = false;//ColumnHeadersVisible
            dGridAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dGridAlumnos.DataSource = null;
                dGridAlumnos.Rows.Clear();
                miTabla.Rows.Clear();

                /* EJEMPLO 01 */
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos WHERE curso = @cursoAFiltrar"; //@cursoAFiltrar es un parámetro.
                //miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1)); //agrgamos un parámetro a la consulta.

                if (miConexion.State != ConnectionState.Open)// Validación
                    miConexion.Open();

                miComando.Parameters.Clear();
                miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", int.Parse(txtBoxCurso.Text)));

                //ejecuto comando
                lector = miComando.ExecuteReader();

                //Pre visualización del comando que mandé
                miTabla.Load(lector);// (click en la lupa)

                //Cargo el dataGridView con los datos del DataTable
                dGridAlumnos.DataSource = miTabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                    miConexion.Close();
            }
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            /* EJEMPLO 02 */
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "INSERT INTO Alumnos VALUES(@legajo,@nombre,@apellido,@cursoAFiltrar)";

            //miComando.Parameters.Clear();//para evitar romperlo
            miComando.Parameters.Add(new SqlParameter("legajo", int.Parse(txtBoxCurso.Text)));
            //va a insertar lo que ponga en el txtboxCurso...
            miComando.Parameters.Add(new SqlParameter("nombre", "Maggie"));
            miComando.Parameters.Add(new SqlParameter("apellido", "Rodi"));
            miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", 1));


            if (miConexion.State != ConnectionState.Open)// Validación
                miConexion.Open();


            int cantidadInsertados = miComando.ExecuteNonQuery();//solo traé la cantidad de inserts


            MessageBox.Show($"Cantidad de inserciones {cantidadInsertados}",
                "Notificación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            miConexion.Close();
        }
    }
}
