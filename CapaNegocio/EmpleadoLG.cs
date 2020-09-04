using CapaDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EmpleadoLG
    {
        public Empleado BuscarEmpleado(int id)
        {
            IEmpleadoAD empleadoAD = null;

            return empleadoAD.BuscarPorID(id);
        }

        public Empleado BuscarPorUsuario(string usuario)
        {
            IEmpleadoAD empleadoAD = null;

            return empleadoAD.BuscarPorUsuario(usuario);

        }

        public bool EsUsuarioValido(string usuario, string clave)
        {
            IEmpleadoAD empleado = null;

            return empleado.EsUsuarioValido(usuario, clave);
        }

        //NOTA: considero que el metodo Guardar en la capa de datos deberia devolver un true o algo que le haga saber
        // a la capa de presentacion que se guardo con exito. Puede ser en esta misma capa tambien que devuelva este valor.
        public void GuardarEmpleado(Empleado empleado)
        {
            IEmpleadoAD empleadoAD = null;

            empleadoAD.Guardar(empleado);
        }
    }
}
