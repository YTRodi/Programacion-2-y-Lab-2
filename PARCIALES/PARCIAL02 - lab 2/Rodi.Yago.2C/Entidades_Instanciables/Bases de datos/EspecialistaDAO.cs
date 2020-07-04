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
    public static class EspecialistaDAO
    {
        #region Atributos
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = ClinicaUtn; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo estático de EspecialistaDAO que establece las conexiones a la base de datos.
        /// </summary>
        static EspecialistaDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }
        #endregion

        #region Métodos para ejecutar querys
        /// <summary>
        /// Método estático que trae todos los especialistas de la tabla Especilistas.
        /// </summary>
        /// <returns>Lista con todos los especialistas.</returns>
        public static List<Especialista> Listar()
        {
            /*
             UPDATE Duenios SET direccion = UPPER(LEFT(veterinaria.dbo.Duenios.direccion, 1)) + 
             LOWER(SUBSTRING(veterinaria.dbo.Duenios.direccion, 2, LEN(veterinaria.dbo.Duenios.direccion)))
             */

            string queryListar = $"SELECT * FROM Especialistas";
            List<Especialista> lstEspecialistas = new List<Especialista>();

            #region Elementos de la tabla Especialista
            int idEspecialista = default(int);
            string apellido = string.Empty;
            string nombre = string.Empty;
            int edad = default(int);
            Persona.ESexo sexo;
            string direccion = string.Empty;
            Especialista.EEspecialidad especialidad;
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
                    int.TryParse(sqlRD["idEspecialista"].ToString(), out idEspecialista);
                    apellido = sqlRD["apellido"].ToString();
                    nombre = sqlRD["nombre"].ToString();
                    int.TryParse(sqlRD["edad"].ToString(), out edad);
                    sexo = (Persona.ESexo)Enum.Parse(typeof(Persona.ESexo), sqlRD["sexo"].ToString());//parseo el enumerado.
                    direccion = sqlRD["direccion"].ToString();
                    especialidad = (Especialista.EEspecialidad)Enum.Parse(typeof(Especialista.EEspecialidad), sqlRD["especialidad"].ToString());//parseo el enumerado.
                    int.TryParse(sqlRD["dni"].ToString(), out dni);

                    lstEspecialistas.Add(new Especialista(idEspecialista, apellido, nombre, edad, sexo, direccion, dni, especialidad));
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

            return lstEspecialistas;
        }


        /// <summary>
        /// Método estático que inserta un especialista en la tabla Especialistas.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>True: Pudo insertarlo.</returns>
        public static bool Insertar(Especialista e)
        {
            bool pudoInsertar = false;
            /*Evito SQL inyection*/
            string queryInsertarP = $"INSERT INTO Especialistas (apellido, nombre, edad, sexo, direccion, especialidad, dni) " +
                                    $"VALUES(@apellido, @nombre, @edad, @sexo, @direccion, @especialidad, @dni)";

            commandDB.Parameters.Clear();
            commandDB.Parameters.AddWithValue("@apellido", e.Apellido);
            commandDB.Parameters.AddWithValue("@nombre", e.Nombre);
            commandDB.Parameters.AddWithValue("@edad", e.Edad);
            commandDB.Parameters.AddWithValue("@sexo", e.Sexo.ToString());
            commandDB.Parameters.AddWithValue("@direccion", e.Direccion);
            commandDB.Parameters.AddWithValue("@especialidad", e.Campo.ToString());
            commandDB.Parameters.AddWithValue("@dni", e.DNI);

            if (EspecialistaDAO.EjecutarQuery(queryInsertarP))
                pudoInsertar = true;

            return pudoInsertar;
        }

        /// <summary>
        /// Método estático que modifica un especialista en la tabla Especialistas por un id en específico.
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="especialidad"></param>
        /// <param name="dni"></param>
        /// <returns>True: Si pudo modificarlo.</returns>
        public static bool Update(int id, string apellido, string nombre, int edad, string sexo, string direccion, string especialidad, int dni)
        {
            bool pudoEditar = false;
            string queryModificar = $"UPDATE Especialistas SET apellido = '{apellido}'" +
                $", nombre = '{nombre}'" +
                $", edad = {edad}" +
                $", sexo = '{sexo}'" +
                $", direccion = '{direccion}'" +
                $", especialidad = '{especialidad}'" +
                $", dni = {dni}" +
                $" WHERE idEspecialista = {id}";

            if (EspecialistaDAO.EjecutarQuery(queryModificar))
                pudoEditar = true;

            return pudoEditar;
        }

        /// <summary>
        /// Método estático que elimina un especialista en la tabla Especialistas por un id en específico.
        /// 
        /// </summary>
        /// <param name="idAEliminar"></param>
        /// <returns>True: Si pudo eliminarlo.</returns>
        public static bool Delete(int idAEliminar)
        {
            bool pudoEliminar = false;
            string queryEliminar = $"DELETE FROM Especialistas WHERE idEspecialista = {idAEliminar}";

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
