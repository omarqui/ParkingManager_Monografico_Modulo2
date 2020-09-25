using CapaDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.ManejadorConexion;

namespace CapaDatos
{
    public class CobroParqueoDA : AccesadorDatos, ICobroParqueoDA, ISecuencia
    {
        public CobroParqueoDA()
        {
            _conexion = ManejadorConexion.Conexion;
        }

        public CobroParqueoDA(SqlConnection conexion)
        {
            _conexion = conexion;
            esConexionAutoManejado = false;
        }

        public DataTable BuscarTodos()
        {
            DataTable dt = new DataTable();
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarCobro"))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            };
        }

        public int Guardar(CobroParqueo cobro, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_InsertarCobro", transaction))
                {
                    cmd.Parameters.AddWithValue("idUso", cobro.IdUso);
                    cmd.Parameters.AddWithValue("IdTurno", cobro.IdTurno);
                    cmd.Parameters.AddWithValue("descuento", cobro.Descuento);
                    cmd.Parameters.AddWithValue("montoCobrado", cobro.TotalCobrado);
                    cmd.Parameters.AddWithValue("montoPagado", cobro.MontoPagado);
                    cmd.Parameters.AddWithValue("devuelta", cobro.Devuelta);

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

        public int ObtenerSecuencia()
        {
            return ObtenerSiguienteSecuenacia("COBRO_PARQUEO", "IdCobro");
        }

        public CobroParqueo BuscarPorID(int id)
        {
            return BuscarCobroBase(new SqlParameter("idCobro",id));
        }

        public CobroParqueo BuscarPorIdUsoParqueo(int id)
        {
            return BuscarCobroBase(new SqlParameter("idUso", id));
        }

        private CobroParqueo BuscarCobroBase(SqlParameter parameter)
        {
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarCobro"))
                {
                    cmd.Parameters.Add(parameter);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CobroParqueo()
                            {
                                IdCobro = reader["IdCobro"] as int? ?? default,
                                IdUso = reader["IdUso"] as int? ?? default,
                                IdTurno = reader["IdTurno"] as int? ?? default,
                                Fecha = reader["fecha"] as DateTime? ?? default,
                                Descuento = reader["Descuento"] as decimal? ?? default,
                                MontoPagado = reader["MontoPagado"] as decimal? ?? default,
                                TotalCobrado = reader["MontoCobrado"] as decimal? ?? default,
                                Devuelta = reader["Devuelta"] as decimal? ?? default,
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
