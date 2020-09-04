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
    public class EmpleadoAD : IEmpleado
    {
        public Empleado BuscarPorID(int id)
        {
            return BuscarEmpleadoBase(new SqlParameter("idEmpleado",id));
        }

        public Empleado BuscarPorUsuario(string usuario)
        {
            return BuscarEmpleadoBase(new SqlParameter("usuario", usuario));
        }

        public bool EsUsuarioValido(string usuario, string clave)
        {
            using (var cmd = new SqlCommand("pa_ValidarUsuario", Conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                using (var Reader = cmd.ExecuteReader())
                    return Reader.Read();
            }
        }

        public int Guardar(Empleado empleado)
        {
            using (var cmd = new SqlCommand("pa_GetUsuario", Conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("Celular", empleado.Celular);                
                cmd.Parameters.AddWithValue("Direccion", empleado.Direccion);
                cmd.Parameters.AddWithValue("EstaActivo", empleado.EstaActivo);
                cmd.Parameters.AddWithValue("Nombre", empleado.Nombre);
                
                if (empleado.IdEmpleado == 0)
                {
                    cmd.Parameters.AddWithValue("Clave", empleado.Clave);
                    cmd.Parameters.AddWithValue("Usuario", empleado.Usuario);
                }

                cmd.Connection.Open();

                var filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        Empleado BuscarEmpleadoBase(SqlParameter parameter)
        {
            using (var cmd = new SqlCommand("pa_GetUsuario", Conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(parameter);
                cmd.Connection.Open();

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
