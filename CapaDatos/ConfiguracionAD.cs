using CapaDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.ManejadorConexion;

namespace CapaDatos
{
    public class ConfiguracionAD : AccesadorDatos
    {
        public ConfiguracionAD()
        {
            _conexion = ManejadorConexion.Conexion;
        }

        public ConfiguracionAD(SqlConnection conexion)
        {
            _conexion = conexion;
            esConexionAutoManejado = false;
        }
        
        public int Guardar(Configuracion configuracion, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_ActualizarConfiguracion", transaction))
                {
                    cmd.Parameters.AddWithValue("CantidadParqueos", configuracion.CantidadParqueos);
                    cmd.Parameters.AddWithValue("DireccionEmpresa", configuracion.DireccionEmpresa);
                    cmd.Parameters.AddWithValue("TelefonoEmpresa", configuracion.TelefonoEmpresa);
                    cmd.Parameters.AddWithValue("NombreEmpresa", configuracion.NombreEmpresa);
                    cmd.Parameters.AddWithValue("PrecioPorHora", configuracion.PrecioPorHora);

                    var filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (esConexionAutoManejado)
                {
                    _conexion.Close();
                }
            }
        }

        public Configuracion Buscar()
        {
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_BuscarConfiguracion"))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Configuracion()
                            {
                                CantidadParqueos = reader["CantidadParqueos"] as int? ?? 0,
                                DireccionEmpresa = reader["DireccionEmpresa"].ToString(),
                                NombreEmpresa = reader["NombreEmpresa"].ToString(),
                                PrecioPorHora = reader["PrecioPorHora"] as decimal? ?? 0,
                                TelefonoEmpresa = reader["TelefonoEmpresa"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public DataTable BuscarDataSet()
        {
            DataTable dt = new DataTable();
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_BuscarConfiguracion"))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
