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
    public class EmpleadoAD : AccesadoDatos, IEmpleadoAD, ISecuencia
    {
        public EmpleadoAD()
        {
            Connection = Conexion;
        }

        public EmpleadoAD(SqlConnection connection)
        {
            Connection = connection;
            esAutoManejado = false;
        }

        public Empleado BuscarPorID(int id)
        {
            return BuscarEmpleadoBase(new SqlParameter("id", id));
        }

        public Empleado BuscarPorUsuario(string usuario)
        {
            return BuscarEmpleadoBase(new SqlParameter("usuario", usuario));
        }

        public bool EsUsuarioValido(string usuario, string clave)
        {

            using (var conn = Connection)
            {
                using (var cmd = CrearCommand(Connection, "pa_ValidarUsuario"))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    using (var Reader = cmd.ExecuteReader())
                        return Reader.Read();
                }
            }

        }

        public int Guardar(Empleado empleado, SqlTransaction transaction = null)
        {
            try
            {
                using (var cmd = CrearCommand(Connection, "pa_insertarEmpleado", transaction))
                {
                    cmd.Parameters.AddWithValue("IdEmpleado", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("Cedula", empleado.Cedula);
                    cmd.Parameters.AddWithValue("Celular", empleado.Celular);
                    cmd.Parameters.AddWithValue("Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("Nombre", empleado.Nombre);

                    if (empleado.IdEmpleado == 0)
                    {
                        cmd.Parameters.AddWithValue("Clave", empleado.Clave);
                        cmd.Parameters.AddWithValue("Usuario", empleado.Usuario);
                    }

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
                if (esAutoManejado)
                {
                    Connection.Close();
                }
            }
        }

        public int ObtenerSecuencia()
        {
            return ObtenerSecuenaciaBase("IdEmpleado", "Empleado");
        }

        public DataTable BuscarTodos()
        {
            DataTable dt = new DataTable();
            using (var conn = Connection)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarEmpleado"))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }

        }

        private Empleado BuscarEmpleadoBase(SqlParameter parameter)
        {
            using (var conn = Connection)
            {
                using (var cmd = CrearCommand(conn, "pa_buscarEmpleado"))
                {
                    cmd.Parameters.Add(parameter);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Empleado()
                            {
                                IdEmpleado = reader["IdEmpleado"] as int? ?? 0,
                                Cedula = reader["Cedula"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Celular = reader["Celular"].ToString(),
                                EstaActivo = reader["EstaActivo"] as bool? ?? false,
                                Usuario = reader["Usuario"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }


    }
}
