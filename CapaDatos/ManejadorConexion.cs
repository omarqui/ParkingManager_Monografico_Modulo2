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
        static private SqlConnection _conexion;

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
            cmd.Connection.Open();

            return cmd;
        }

        //public static SqlCommand CrearCommandConTransaccion(
        //    string cmdText,
        //    out SqlTransaction transaction,
        //    CommandType type = CommandType.StoredProcedure)
        //{
        //    var cmd = CrearCommand(cmdText, type: type);
        //    transaction = cmd.Connection.BeginTransaction();
        //    cmd.Transaction = transaction;

        //    return cmd;
        //}

        public static int ObtenerSecuenaciaBase(string nombreCampoSecuencia,
                                            string nombreTabla)
        {
            string cmdText = $@"SELECT MAX({nombreCampoSecuencia})+1 secuencia
                                FROM {nombreTabla}";
            using (var conn = Conexion)
            {
                using (var cmd = CrearCommand(conn, cmdText, type: CommandType.Text))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int secuencia = reader["secuencia"] as int? ?? 1;
                            return secuencia;
                        }
                    }
                }
            }

            return 1;
        }
    }
}
