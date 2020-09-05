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
    public class EmpleadoAD : IEmpleadoAD, ISecuencia
    {
        public Empleado BuscarPorID(int id)
        {
            return BuscarEmpleadoBase(new SqlParameter("id",id));
        }

        public Empleado BuscarPorUsuario(string usuario)
        {
            return BuscarEmpleadoBase(new SqlParameter("usuario", usuario));
        }

        public bool EsUsuarioValido(string usuario, string clave)
        {
            using (var cmd = MakeCommand("pa_ValidarUsuario"))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                using (var Reader = cmd.ExecuteReader())
                    return Reader.Read();
            }
        }

        public int Guardar(Empleado empleado)
        {
            using (var cmd = MakeCommand("pa_insertarEmpleado"))
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

        public int ObtenerSecuencia()
        {
            return ObtenerSecuenaciaBase("IdEmpleado", "Empleado");
        }

        public DataTable BuscarTodos()
        {
            DataTable dt = new DataTable();
            using (var cmd = MakeCommand("pa_buscarEmpleado"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        private Empleado BuscarEmpleadoBase(SqlParameter parameter)
        {
            using (var cmd = MakeCommand("pa_buscarEmpleado"))
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

            return null;
        }

        
    }
}
