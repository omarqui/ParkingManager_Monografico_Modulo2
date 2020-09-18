using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ManejadorConexion
    {
        static public SqlConnection Conexion
        {
            get
            {
                string cadenaConexion;

                string dir = AppDomain.CurrentDomain.BaseDirectory;
                string file = dir + "\\Local.config";
                if (File.Exists(file))
                {
                    StreamReader leerConexion = new StreamReader(file);
                    cadenaConexion = leerConexion.ReadLine();
                }
                else
                {
                    cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
                }

                return new SqlConnection(cadenaConexion);
            }
        }

        public static SqlCommand CrearCommand(
            SqlConnection connection,
            string cmdText,
            SqlTransaction transaction = null,
            CommandType type = CommandType.StoredProcedure)
        {
            var cmd = new SqlCommand(cmdText, connection)
            {
                Transaction = transaction,
                CommandType = type
            };
            if (connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            return cmd;
        }

        //public static SqlCommand CrearCommand(
        //    SqlConnection connection,
        //    string cmdText,
        //    out SqlTransaction transaction,
        //    CommandType type = CommandType.StoredProcedure)
        //{

        //    var cmd = new SqlCommand(cmdText, connection)
        //    {
        //        CommandType = type
        //    };
        //    cmd.Connection.Open();
        //    transaction = cmd.Connection.BeginTransaction();
        //    cmd.Transaction = transaction;

        //    return cmd;
        //}

        public static int ObtenerSiguienteSecuenacia(
            string nombreTabla,
            string nombreCampoSecuencia)
        {
            string cmdText = "usp_getNextSequence";

            using (var conn = Conexion)
            {
                using (var cmd = CrearCommand(conn, cmdText))
                {
                    cmd.Parameters.AddWithValue("tableName", nombreTabla);
                    cmd.Parameters.AddWithValue("columnName", nombreCampoSecuencia);                    

                    var secuencia = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    secuencia.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteReader();
                    return (int)secuencia.Value;
                }
            }
        }
    }
}
