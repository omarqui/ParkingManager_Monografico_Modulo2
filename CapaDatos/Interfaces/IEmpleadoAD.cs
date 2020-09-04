using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    public interface IEmpleadoAD
    {
        void Guardar(Empleado empleado);

        Empleado BuscarPorID(int id);

        Empleado BuscarPorUsuario(string usuario);

        bool EsUsuarioValido(string usuario, string clave);
    }
}
