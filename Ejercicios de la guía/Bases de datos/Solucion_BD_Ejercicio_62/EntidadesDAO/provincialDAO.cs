using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDAO
{
    public class provincialDAO
    {
        #region Attributes for connection
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = Centralita; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        #endregion

        #region Constructors
        static provincialDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }
        #endregion

        #region Methods
        public static bool Guardar(Llamada llamadaProvincial)
        {
            bool pudoAgregar = false;
            string queryInsertarLLamada = $"INSERT INTO Llamadas (Duracion,Origen,Destino,Costo,Tipo) " +
                $"VALUES({(int)llamadaProvincial.Duracion},'{llamadaProvincial.NroOrigen}','{llamadaProvincial.NroDestino}',{(int)llamadaProvincial.CostoLlamada},1)";

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
                throw new Exception("Se produjo una excepción en el método Guardar de la clase provincialDAO.", ex);
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

                    lstLlamadas.Add(new Provincial(origen, Provincial.Franja.Franja_1, duracion, destino));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepción en el método Leer de la clase provincialDAO.", ex);
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
