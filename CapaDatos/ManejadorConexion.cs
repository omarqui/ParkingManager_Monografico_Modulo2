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
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();

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
            string cmdText = "pa_buscarSiguienteSecuencia";

            using (var conn = Conexion)
            {
                using (var cmd = CrearCommand(conn, cmdText))
                {
                    cmd.Parameters.AddWithValue("nombreTabla", nombreTabla);
                    cmd.Parameters.AddWithValue("nombreColumna", nombreCampoSecuencia);                    

                    var secuencia = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    secuencia.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteReader();
                    return (int)secuencia.Value;
                }
            }
        }
    }
}
