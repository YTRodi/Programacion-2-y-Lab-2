using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        #region Attributes for connection
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = Centralita; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        #endregion

        #region Constructors
        static LocalDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }
        #endregion

        #region Methods
        public static bool Guardar(Local llamadaLocal)
        {
            bool pudoAgregar = false;
            string queryInsertarLLamada = $"INSERT INTO Llamadas (Duracion,Origen,Destino,Costo,Tipo) " +
                $" VALUES('{(int)llamadaLocal.Duracion}','{llamadaLocal.NroOrigen}','{llamadaLocal.NroDestino}',{(int)llamadaLocal.CostoLlamada},0)";
            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryInsertarLLamada;
                commandDB.ExecuteNonQuery();
                pudoAgregar = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Guardar de la clase LocalDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }
            return pudoAgregar;
        }

        public static List<Llamada> Leer()
        {
            List<Llamada> lstLlamadas = new List<Llamada>();
            string queryListar = "SELECT * FROM Llamadas";

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryListar;

                SqlDataReader sqlRD = commandDB.ExecuteReader();


                while (sqlRD.Read())
                {
                    //int id = default(int);
                    //int.TryParse(sqlRD["id"].ToString(), out id);

                    int duracion = default(int);
                    int.TryParse(sqlRD["Duracion"].ToString(), out duracion);

                    string origen = sqlRD["Origen"].ToString();
                    string destino = sqlRD["Destino"].ToString();

                    float costo = default(float);
                    float.TryParse(sqlRD["Costo"].ToString(), out costo);

                    int tipo = default(int);
                    int.TryParse(sqlRD["Tipo"].ToString(), out tipo);


                    lstLlamadas.Add(new Local(origen,(float)duracion,destino,costo));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Leer de la clase LocalDAO.", ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return lstLlamadas;
        }

        public static string MostrarDatos(List<Llamada> lstLlamadas)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Local item in lstLlamadas)
            {
                sb.AppendLine(item.ToString());

            }
            return sb.ToString();
        }
        #endregion
    }
}
