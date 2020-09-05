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
                if (_conexion == null)
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
                    
                    _conexion = new SqlConnection(cadenaConexion);
                }

                return _conexion;
            }
        }

        public static SqlCommand MakeCommand(string cmdText, CommandType type = CommandType.StoredProcedure)
        {
            var cmd = new SqlCommand(cmdText, Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();

            return cmd;
        }
    }
}
