using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades_Abstractas;
using Entidades_Instanciables;
using Excepciones;

namespace Entidades_Instanciables.Bases_de_datos
{
    public static class PacienteDAO
    {
        #region Atributos
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = ClinicaUtn; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo estático de PacienteDAO que establece las conexiones a la base de datos.
        /// </summary>
        static PacienteDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }
        #endregion

        #region Métodos para ejecutar querys
        /// <summary>
        /// Método estático que trae todos los pacientes de la tabla Pacientes.
        /// </summary>
        /// <returns>Lista con todos los pacientes.</returns>
        public static List<Paciente> Listar()
        {
            string queryListar = $"SELECT * FROM Pacientes";
            List<Paciente> lstPacientes = new List<Paciente>();

            #region Elementos de la tabla Pacientes
            int idPaciente = default(int);
            string apellido = string.Empty;
            string nombre = string.Empty;
            int edad = default(int);
            Persona.ESexo sexo;
            string direccion = string.Empty;
            Paciente.EObraSocial obraSocial;
            int dni = default(int);
            #endregion

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryListar;

                SqlDataReader sqlRD = commandDB.ExecuteReader();


                while (sqlRD.Read())
                {
                    int.TryParse(sqlRD["idPaciente"].ToString(), out idPaciente);
                    apellido = sqlRD["apellido"].ToString();
                    nombre = sqlRD["nombre"].ToString();
                    int.TryParse(sqlRD["edad"].ToString(), out edad);
                    sexo = (Persona.ESexo)Enum.Parse(typeof(Persona.ESexo), sqlRD["sexo"].ToString());//parseo el enumerado.
                    direccion = sqlRD["direccion"].ToString();
                    obraSocial = (Paciente.EObraSocial)Enum.Parse(typeof(Paciente.EObraSocial), sqlRD["obraSocial"].ToString());//parseo el enumerado.
                    int.TryParse(sqlRD["dni"].ToString(), out dni);

                    lstPacientes.Add(new Paciente(idPaciente, apellido, nombre, edad, sexo, direccion, dni, obraSocial));
                }
            }
            catch (Exception ex)
            {
                throw new BDException("Ocurrio un error al querer leer los elementos de la base de datos.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return lstPacientes;
        }

        /// <summary>
        /// Método estático que inserta un paciente en la tabla Pacientes.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>True: Pudo insertarlo.</returns>
        public static bool Insertar(Paciente p)
        {
            bool pudoInsertar = false;
            /*Evito SQL inyection*/
            string queryInsertarP = $"INSERT INTO Pacientes (apellido, nombre, edad, sexo, direccion, obraSocial, dni) " +
                                    $"VALUES(@apellido, @nombre, @edad, @sexo, @direccion, @obraSocial, @dni)";

            commandDB.Parameters.Clear();
            commandDB.Parameters.AddWithValue("@apellido", p.Apellido);
            commandDB.Parameters.AddWithValue("@nombre", p.Nombre);
            commandDB.Parameters.AddWithValue("@edad", p.Edad);
            commandDB.Parameters.AddWithValue("@sexo", p.Sexo.ToString());
            commandDB.Parameters.AddWithValue("@direccion", p.Direccion);
            commandDB.Parameters.AddWithValue("@obraSocial", p.ObraSocial.ToString());
            commandDB.Parameters.AddWithValue("@dni", p.DNI);

            if (PacienteDAO.EjecutarQuery(queryInsertarP))
                pudoInsertar = true;

            return pudoInsertar;
        }

        /// <summary>
        /// Método estático que modifica un paciente en la tabla Pacientes por un id en específico.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="obraSocial"></param>
        /// <param name="dni"></param>
        /// <returns>True: Si pudo modificar.</returns>
        public static bool Update(int id,string apellido, string nombre, int edad, string sexo, string direccion, string obraSocial, int dni)
        {
            bool pudoEditar = false;
            string queryModificar = $"UPDATE Pacientes SET apellido = '{apellido}'" +
                $", nombre = '{nombre}'" +
                $", edad = {edad}" +
                $", sexo = '{sexo}'" +
                $", direccion = '{direccion}'" +
                $", obraSocial = '{obraSocial}'" +
                $", dni = {dni}" +
                $" WHERE idPaciente = {id}";

            if (PacienteDAO.EjecutarQuery(queryModificar))
                pudoEditar = true;
            
            return pudoEditar;
        }

        /// <summary>
        /// Método estático que elimina un paciente en la tabla Pacientes por un id en específico.
        /// </summary>
        /// <param name="idAEliminar"></param>
        /// <returns>True: Si pudo eliminarlo.</returns>
        public static bool Delete(int idAEliminar)
        {
            bool pudoEliminar = false;
            string queryEliminar = $"DELETE FROM Pacientes WHERE idPaciente = {idAEliminar}";

            if (PacienteDAO.EjecutarQuery(queryEliminar))
                pudoEliminar = true;
            
            return pudoEliminar;
        }
        #endregion

        #region Ejecutador de querys
        /// <summary>
        /// Método que verifica el estado de la conexión y ejecuta la query.
        /// </summary>
        /// <returns>Si pudo ejecutar la query o no.</returns>
        public static bool EjecutarQuery(string query)
        {
            bool pudoEjecutar = false;
            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = query;
                commandDB.ExecuteNonQuery();

                pudoEjecutar = true;
            }
            catch (Exception ex)
            {
                throw new BDException("Ocurrio un error en querer Agregar/Modificar/Eliminar un producto en la base de datos.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }
            return pudoEjecutar;
        }
        #endregion
    }
}
