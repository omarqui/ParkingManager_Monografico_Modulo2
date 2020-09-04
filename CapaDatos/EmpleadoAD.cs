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
            throw new NotImplementedException();
        }

        public Empleado BuscarPorUsuario(string usuario)
        {
            throw new NotImplementedException();
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

        public void Guardar(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}
