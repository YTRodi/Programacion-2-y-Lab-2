using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class ElectrodomesticoDAO
    {
        #region Attributes for connection
        private static string strConnection = @"Data Source = .\SQLEXPRESS; Database = CentralVentas; Trusted_Connection = True;";
        private static SqlConnection connectionDB;
        private static SqlCommand commandDB;
        private static SqlDataReader readerDB;
        #endregion

        static ElectrodomesticoDAO()
        {
            connectionDB = new SqlConnection(strConnection);
            commandDB = new SqlCommand();
            commandDB.Connection = connectionDB;
            commandDB.CommandType = System.Data.CommandType.Text;
        }

        public static bool Guardar(Electrodomestico electro)
        {
            bool pudoAgregar = false;
            commandDB.Parameters.Clear();
            string queryInsertarElec = $"INSERT INTO Electrodomesticos (Modelo,Descripcion,FuncionPrincipal,PrecioNeto,Color,Garantia) " +
                $"VALUES(@modelo,@descripcion,@funcPrinc,@precioNeto,@color,@garantia)";
            try
            {
                commandDB.CommandText = queryInsertarElec;
                commandDB.Parameters.Add(new SqlParameter("modelo", electro.Modelo));
                commandDB.Parameters.Add(new SqlParameter("descripcion", electro.Descripcion));
                commandDB.Parameters.Add(new SqlParameter("funcPrinc", electro.FuncPrincipal));
                commandDB.Parameters.Add(new SqlParameter("@precioNeto", electro.PrecioNeto));
                commandDB.Parameters.Add(new SqlParameter("@color", electro.Color.ToString()));
                commandDB.Parameters.Add(new SqlParameter("@garantia", electro.Garantia));

                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

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

        public static List<Electrodomestico> Leer()
        {
            //commandDB.Parameters.Clear();
            string queryLeerElec = "SELECT * FROM Electrodomesticos";
            List<Electrodomestico> lstElectro = new List<Electrodomestico>();

            #region Atributos de un electrodomestico
            string pModelo = string.Empty;
            string pDescripcion = string.Empty;
            string pFuncPrinc = string.Empty;
            float pPrecioNeto = 0;
            Electrodomestico.EColor pColor;
            bool pGarantia = false;
            #endregion

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryLeerElec;
                
                readerDB = commandDB.ExecuteReader();

                while (readerDB.Read())
                {
                    pModelo = readerDB["Modelo"].ToString();
                    pDescripcion = readerDB["Descripcion"].ToString();
                    pFuncPrinc = readerDB["FuncionPrincipal"].ToString();
                    pPrecioNeto = float.Parse(readerDB["PrecioNeto"].ToString());//. to string()???
                    pColor = (Electrodomestico.EColor)Enum.Parse(typeof(Electrodomestico.EColor),readerDB["Color"].ToString());//casteo a el tipo de enum
                    pGarantia = (bool)readerDB["Garantia"];

                    lstElectro.Add(new Electrodomestico(pModelo, pDescripcion, pFuncPrinc, pPrecioNeto, pColor, pGarantia));
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
            return lstElectro;
        }

        public static bool Borrar(int idAEliminar)
        {
            bool pudoBorrar = false;
            string queryBorrar = $"DELETE FROM Electrodomesticos WHERE id = {idAEliminar}";

            try
            {
                if (connectionDB.State != System.Data.ConnectionState.Open)
                    connectionDB.Open();

                commandDB.CommandText = queryBorrar;
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

        public static bool Modificar(Electrodomestico elect,int idAModificar)
        {
            bool pudoModificar = false;
            string queryModificar = $"UPDATE Electrodomesticos SET" +
                                    $" Modelo = '{elect.Modelo}'," +
                                    $" Descripcion = '{elect.Descripcion}'," +
                                    $" FuncionPrincipal = '{elect.FuncPrincipal}'," +
                                    $" PrecioNeto = {elect.PrecioNeto}," +
                                    $" Color = '{elect.Color}'," +
                                    $" Garantia = {Convert.ToInt32(elect.Garantia)}"+
                                    $" WHERE id = {idAModificar}";
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
    }
}
