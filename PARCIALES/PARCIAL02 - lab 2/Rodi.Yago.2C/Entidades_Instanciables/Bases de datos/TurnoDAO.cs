using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades_Abstractas;
using Entidades_Instanciables;
using Excepciones;
using System.Data.Common;
using System.Security.Policy;

//namespace Bases_de_datos
namespace Entidades_Instanciables.Bases_de_datos
{
    public static class TurnoDAO
    {
        #region Atributos
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = ClinicaUtn; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo estático de TurnoDAO que establece las conexiones a la base de datos.
        /// </summary>
        static TurnoDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }
        #endregion

        #region Métodos que ejecutan querys
        /// <summary>
        /// Método estático que trae todos los turnos de la tabla Turnos.
        /// </summary>
        /// <returns>Lista con todos los turnos.</returns>
        public static List<Turno> ListarTurnos()
        {
            string queryListar = $"SELECT T.idTurno," +
                $" P.apellido," +
                $" P.nombre," +
                $" P.sexo," +
                $" E.apellido AS 'apellidoE'," +
                $" E.especialidad," +
                $" T.observacionesTurno," +
                $" T.fechaTurno" +
                $" FROM Turnos AS T" +
                $" LEFT JOIN Pacientes AS P ON T.idPaciente = P.idPaciente" +
                $" LEFT JOIN Especialistas AS E ON T.idEspecialista = E.idEspecialista";

            List<Turno> lstTurnos = new List<Turno>();

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryListar;

                SqlDataReader sqlRD = commandDB.ExecuteReader();


                while (sqlRD.Read())
                {
                    Paciente p = new Paciente();
                    Especialista e = new Especialista();
                    int idTurno = default(int);
                    string observaciones = string.Empty;
                    string fechaTurno = string.Empty;

                    int.TryParse(sqlRD["idTurno"].ToString(), out idTurno);
                    p.Apellido = sqlRD["apellido"].ToString();
                    p.Nombre = sqlRD["nombre"].ToString();
                    p.Sexo = (Persona.ESexo)Enum.Parse(typeof(Persona.ESexo), sqlRD["sexo"].ToString());//parseo el enumerado.
                    e.Apellido = sqlRD["apellidoE"].ToString();
                    e.Campo = (Especialista.EEspecialidad)Enum.Parse(typeof(Especialista.EEspecialidad), sqlRD["especialidad"].ToString());//parseo el enumerado.
                    observaciones = sqlRD["observacionesTurno"].ToString();
                    fechaTurno = sqlRD["fechaTurno"].ToString();


                    lstTurnos.Add(new Turno(idTurno, p, e, observaciones, Convert.ToDateTime(fechaTurno)));
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

            return lstTurnos;
        }

        /// <summary>
        /// Método estático que inserta un turno en la tabla Turnos.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <param name="idEspecialista"></param>
        /// <param name="observacionesTurno"></param>
        /// <param name="fechaTurno"></param>
        /// <returns>True: Si pudo inserta el turno.</returns>
        public static bool Insert(int idPaciente, int idEspecialista, string observacionesTurno, string fechaTurno)
        {
            bool pudoAgregar = false;

            string queryInsertarT = $"INSERT INTO Turnos (idPaciente,idEspecialista,observacionesTurno,fechaTurno) " +
                $"VALUES (@idP,@idE,@observacionesT,@fechaT)";

            commandDB.Parameters.Clear();
            commandDB.Parameters.AddWithValue("@idP", idPaciente);
            commandDB.Parameters.AddWithValue("@idE", idEspecialista);
            commandDB.Parameters.AddWithValue("@observacionesT", observacionesTurno);
            commandDB.Parameters.AddWithValue("@fechaT", fechaTurno);

            if (TurnoDAO.EjecutarQuery(queryInsertarT))
            {
                pudoAgregar = true;
            }

            return pudoAgregar;
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
