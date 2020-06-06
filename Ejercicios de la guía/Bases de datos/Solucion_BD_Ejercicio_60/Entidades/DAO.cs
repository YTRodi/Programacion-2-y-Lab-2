using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class DAO
    {
        #region Attributes for connection to the database
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        private static DataTable dataTb;
        #endregion

        #region Querys
        private static string listarProductos = "SELECT * FROM Production.Product";
        private static string insertarProducto = "INSERT INTO Production.Product (nombre,apellido, dni)";
        #endregion

        static DAO()
        {
            string connectionSTR = @"Data Source = .\SQLEXPRESS; Database = AdventureWorks2017; Trusted_Connection = True;";
            DAO.connectionDB = new SqlConnection(connectionSTR);
            DAO.commandDB = new SqlCommand();
            DAO.dataTb = new DataTable();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }

        public static object ListarProductos()
        {
            object retornoDatos = new object();

            try
            {
                SqlCommand commandDBList = new SqlCommand(listarProductos, DAO.connectionDB);

                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                DAO.commandDB.CommandText = DAO.listarProductos;
                SqlDataReader readerData = commandDB.ExecuteReader();

                dataTb.Load(readerData);

                retornoDatos = dataTb;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }
            return retornoDatos;
        }

        public static bool InsertarProducto(string nombreProducto, string numeroProducto, Producto.EColores colorProducto)
        {
            bool pudoInsertar = false;

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                //string comando = String.Format("INSERT INTO CLIENTES (nombre,apellido, dni) " +
                //  "VALUES ('{0}', '{1}', '{2}');", nombre, apellido, dni);
                //DAO.commandDB.CommandText = "INSERT INTO Production.Product VALUES(@nombreProducto,@numeroProducto,@colorProducto)";
                //DAO.commandDB.CommandText = DAO.insertarProducto;
                DAO.commandDB.CommandText = "INSERT INTO Production.Product (Name,ProductNumber,Color)" +
                    $"VALUES({nombreProducto},{numeroProducto},{colorProducto})";
                //DAO.commandDB.Parameters.Add(new SqlParameter("nombreProducto", nombreProducto));
                //DAO.commandDB.Parameters.Add(new SqlParameter("numeroProducto", numeroProducto));
                //DAO.commandDB.Parameters.Add(new SqlParameter("colorProducto", colorProducto));

                DAO.commandDB.ExecuteNonQuery();
                pudoInsertar = true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (connectionDB.State != System.Data.ConnectionState.Closed)
                    connectionDB.Close();
            }

            return pudoInsertar;
            //object retornoDatos = new object();

            //try
            //{
            //    SqlCommand commandDBList = new SqlCommand(listarProductos, DAO.connectionDB);

            //    if (connectionDB.State != System.Data.ConnectionState.Open)
            //        connectionDB.Open();

            //    DAO.commandDB.CommandText = DAO.listarProductos;
            //    SqlDataReader readerData = commandDB.ExecuteReader();

            //    dataTb.Load(readerData);

            //    retornoDatos = dataTb;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message, ex);
            //}
            //finally
            //{
            //    if (connectionDB.State != System.Data.ConnectionState.Closed)
            //        connectionDB.Close();
            //}
            //return retornoDatos;


        }
    }
}
