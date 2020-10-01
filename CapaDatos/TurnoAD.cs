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
    public class TurnoAD : AccesadorDatos, ITurnoAD, ISecuencia
    {
        public TurnoAD() : base()
        {
            
        }

        public TurnoAD(SqlConnection conexion)
        {
            _conexion = conexion;
            esConexionAutoManejado = false;
        }

        public int Aperturar(Turno turno, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_aperturar_turno", transaction))
                {
                    cmd.Parameters.AddWithValue("idEmpleado", turno.IdEmpleado);
                    cmd.Parameters.AddWithValue("montoApertura", turno.MontoApertura);

                    var idTurno = cmd.Parameters.Add("@idTurno", SqlDbType.Int);
                    idTurno.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();

                    return (int)idTurno.Value;
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

        public Turno BuscarPorID(int id)
        {
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarTurno"))
                {
                    cmd.Parameters.AddWithValue("idTurno", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Turno()
                            {
                                IdTurno = reader["idTurno"] as int? ?? 0,
                                FechaApertura = reader["FechaApertura"] as DateTime? ?? default,
                                FechaCierre = reader["FechaCierre"] as DateTime? ?? default,
                                IdEmpleado = reader["IdEmpleado"] as int? ?? default,
                                MontoApertura = reader["MontoApertura"] as decimal? ?? default,
                                MontoCobrado = reader["MontoCobrado"] as decimal? ?? default,
                                MontoDiferencia = reader["MontoDiferencia"] as decimal? ?? default,
                                MontoEntregado = reader["MontoEntregado"] as decimal? ?? default,
                                EstaAbierto = reader["EstaAbierto"] as bool? ?? default
                            };
                        }
                    }
                }
            }

            return null;
        }

        public Turno BuscarUltimoTurnoAbiertoEmpleado(int id)
        {
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_BuscarUltimoTurnoAbiertoEmpleado"))
                {
                    cmd.Parameters.AddWithValue("idEmpleado", id);
                    var idTurno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    idTurno.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();
                    int idTurnoAbierto = (int)idTurno.Value;
                    if (idTurnoAbierto > 0)
                    {
                        return BuscarPorID(idTurnoAbierto);
                    }

                    return null;
                }
            }
        }

        public DataTable BuscarTodos(int? idTurno, DateTime fechaDesde,  DateTime fechaHasta, bool? estaAbierto)
        {
            DataTable dt = new DataTable();
            using (var conn = _conexion)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarTurno"))
                {
                    cmd.Parameters.AddWithValue("idTurno", idTurno);
                    cmd.Parameters.AddWithValue("FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("FechaHasta", fechaHasta);
                    cmd.Parameters.AddWithValue("EstaAbierto", estaAbierto);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public int Cerrar(Turno turno, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(_conexion, "pa_cerrar_turno", transaction))
                {
                    cmd.Parameters.AddWithValue("idTurno", turno.IdTurno);
                    cmd.Parameters.AddWithValue("montoCobrado", turno.MontoCobrado);
                    cmd.Parameters.AddWithValue("MontoEntregado", turno.MontoEntregado);
                    cmd.Parameters.AddWithValue("MontoDiferencia", turno.MontoDiferencia);
                    cmd.Parameters.AddWithValue("TotalEnCaja", turno.TotalEnCaja);

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
            return ObtenerSiguienteSecuenacia("TURNO", "IdTurno");
        }
        
        /// <summary>
        /// Funcion que busca la sumatoria del turno a cerrar y devuelve el monto total cobrado
        /// </summary>
        /// <param name="idTurno"> Representa el identificador unico del turno que se está cerrando </param>
        /// <returns>Valor de la sumarotia retornado</returns>
        public decimal BuscarSumatoriaCierreTurno(int idTurno)
        {
            string cmdText = "pa_BuscarSumatoriaCierreTurno";
            decimal montoCobratoTotalTurno = 0;

            using (var conn = Conexion)
            {
                using (var cmd = CrearCommand(conn, cmdText))
                {
                    cmd.Parameters.AddWithValue("idTurno", idTurno);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        montoCobratoTotalTurno = (decimal)reader["MontoCobrado"] as decimal? ?? default;                            
                    }
                }
            }

            return montoCobratoTotalTurno;
        }

    }
}
