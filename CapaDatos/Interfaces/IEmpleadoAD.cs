using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    public interface IEmpleadoAD
    {
        int Guardar(Empleado empleado, SqlTransaction transaction = null);

        Empleado BuscarPorID(int id);

        Empleado BuscarPorUsuario(string usuario);

        bool EsUsuarioValido(string usuario, string clave);
    }
}
