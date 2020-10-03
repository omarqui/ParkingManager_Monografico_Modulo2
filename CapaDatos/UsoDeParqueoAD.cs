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
    public class UsoDeParqueoAD : AccesadorDatos, IUsoDeParqueo, ISecuencia
    {
        public UsoDeParqueoAD()
        {
            _conexion = ManejadorConexion.Conexion;
        }

        public UsoDeParqueoAD(SqlConnection conexion)
        {
            _conexion = conexion;
            esConexionAutoManejado = false;
        }

        public int AperturarUso(int idTurno, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_AperturarUso", transaction))
                {
                    cmd.Parameters.AddWithValue("IdTurno", idTurno);

                    var idGenerado = cmd.Parameters.Add("idGenerado", SqlDbType.Int);
                    idGenerado.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();

                    return (int)idGenerado.Value;
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

        public int BuscarCantidadParqueoOcupados()
        {
            using (var conn = Conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarCantidadParqueosDisponibles"))
                {
                    var cantidadDisponobles = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    cantidadDisponobles.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteReader();
                    return (int)cantidadDisponobles.Value;
                }
            }
        }

        public UsoDeParqueo BuscarPorID(int id)
        {
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarUso"))
                {
                    cmd.Parameters.AddWithValue("idUso", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UsoDeParqueo usoDeParqueo = new UsoDeParqueo()
                            {
                                IdUso = reader["IdUso"] as int? ?? default,
                                IdTurno = reader["IdTurno"] as int? ?? default,
                                FechaEntrada = reader["FechaEntrada"] as DateTime? ?? default,
                                FechaSalida = reader["FechaSalida"] as DateTime? ?? default,
                                PrecioPorMinuto = reader["PrecioPorMinuto"] as decimal? ?? default,
                                TiempoUso = reader["TiempoUso"] as decimal? ?? default,
                                Total = reader["Total"] as decimal? ?? default,
                                EstaActivo = reader["EstaActivo"] as bool? ?? default,
                            };

                            if (usoDeParqueo.EstaActivo && usoDeParqueo.FechaSalida != null)
                            {
                                CobroParqueoDA cobroRepositorio = new CobroParqueoDA();
                                usoDeParqueo.Cobro = cobroRepositorio.BuscarPorIdUsoParqueo(usoDeParqueo.IdUso);
                            }
                            
                            return usoDeParqueo;
                        }
                    }
                }
            }

            return null;
        }

        public DataTable BuscarTodos(
            DateTime? desde = null,
            DateTime? hasta = null,
            int? idCajero = null,
            string estado = null,
            string textoAbierto = null)
        {
            DataTable dt = new DataTable();
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarUso"))
                {
                    cmd.Parameters.AddWithValue("desde", desde);
                    cmd.Parameters.AddWithValue("hasta", hasta);
                    cmd.Parameters.AddWithValue("cajero", idCajero);
                    cmd.Parameters.AddWithValue("estado", estado);
                    cmd.Parameters.AddWithValue("textoAbierto", textoAbierto);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            };
        }

        public int CancelarUso(int idUso, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_CancelarUso", transaction))
                {
                    cmd.Parameters.AddWithValue("IdUso", idUso);
                    
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

        public int CerrarUso(UsoDeParqueo uso, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_CerrarUso", transaction))
                {
                    cmd.Parameters.AddWithValue("idUso", uso.IdUso);
                    cmd.Parameters.AddWithValue("IdTurno", uso.IdTurno);
                    cmd.Parameters.AddWithValue("fechaSalida", uso.FechaSalida);
                    cmd.Parameters.AddWithValue("total", uso.Total);
                    cmd.Parameters.AddWithValue("tiempo", uso.TiempoUso);

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
            return ObtenerSiguienteSecuenacia("USO_DE_PARQUEO", "IdUso");
        }

        public DataTable BuscarTicketImpresion(int idUsoParqueo)
        {
            DataTable dt = new DataTable();
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_BuscarTicketImpresion"))
                {
                    cmd.Parameters.AddWithValue("idUsoParqueo", idUsoParqueo);
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
