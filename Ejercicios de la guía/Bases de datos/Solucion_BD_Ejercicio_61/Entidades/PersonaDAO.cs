using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        #region Attributes for connection
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = miBD; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        #endregion

        static PersonaDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }
        public static bool Guardar(Persona persona)
        {
            bool pudoAgregar = false;
            string queryInsertarP = $"INSERT INTO Persona (nombre,apellido) VALUES('{persona.Nombre}','{persona.Apellido}')";
            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryInsertarP;
                commandDB.ExecuteNonQuery();
                pudoAgregar = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Guardar de la clase PersonaDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }
            return pudoAgregar;
        }

        public static List<Persona> Leer()
        {
            List<Persona> lstPersonas = new List<Persona>();
            string queryListar = "SELECT * FROM Persona";

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryListar;

                SqlDataReader sqlRD = commandDB.ExecuteReader();


                while (sqlRD.Read())
                {
                    int id = default(int);
                    int.TryParse(sqlRD["id"].ToString(), out id);
                    string nombre = sqlRD["nombre"].ToString();
                    string apellido = sqlRD["apellido"].ToString();

                    lstPersonas.Add(new Persona(id, nombre, apellido));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Leer de la clase PersonaDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return lstPersonas;
        }

        public static Persona LeerPorID(int idALeer)
        {
            //Se puede hacer de otra forma... No es así..
            //Falta reutilizar código en modificar y eliminar.
            Persona personaLeida = null;
            string queryLeerPorID = $"SELECT * FROM Persona WHERE id = {idALeer}";

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryLeerPorID;

                SqlDataReader sqlRD = commandDB.ExecuteReader();

                while (sqlRD.Read())
                {
                    int id = default(int);
                    int.TryParse(sqlRD["id"].ToString(), out id);
                    string nombre = sqlRD["nombre"].ToString();
                    string apellido = sqlRD["apellido"].ToString();

                    personaLeida = new Persona(id, nombre, apellido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método LeerPorID de la clase PersonaDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return personaLeida;
        }

        public static bool Modificar(Persona personaAModificar)
        {
            bool pudoModificar = false;
            string queryModificar = $"UPDATE Persona SET nombre = '{personaAModificar.Nombre}', apellido = '{personaAModificar.Apellido}' WHERE id = {personaAModificar.ID}";

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryModificar;
                commandDB.ExecuteNonQuery();
                pudoModificar = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Modificar de la clase PersonaDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return pudoModificar;
        }

        public static bool Borrar(int idAEliminar)
        {
            bool pudoBorrar = false;
            string queryEliminar = $"DELETE FROM Persona WHERE id = {idAEliminar}";

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryEliminar;
                commandDB.ExecuteNonQuery();
                pudoBorrar = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Borrar de la clase PersonaDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return pudoBorrar;
        }
    }
}
