using CapaDatos;
using CapaDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EmpleadoLG
    {
        public static Empleado BuscarEmpleado(int id)
        {
            IEmpleadoAD empleadoAD = new EmpleadoAD();

            return empleadoAD.BuscarPorID(id);
        }

        public static Empleado BuscarPorUsuario(string usuario)
        {
            IEmpleadoAD empleadoAD = null;

            return empleadoAD.BuscarPorUsuario(usuario);

        }

        public static bool EsUsuarioValido(string usuario, string clave)
        {
            IEmpleadoAD empleado = new EmpleadoAD();

            return empleado.EsUsuarioValido(usuario, clave);
        }

        public int GuardarEmpleado(Empleado empleado)
        {
            //IEmpleadoAD empleadoAD = null;
            EmpleadoAD empleadoAD = new EmpleadoAD();

            return empleadoAD.Guardar(empleado);
        }

        public static int ObtenerSecuencia()
        {
            ISecuencia obtenerSecuencia = new EmpleadoAD();

            return obtenerSecuencia.ObtenerSecuencia();
        }

        //Buscar todos los empleados para cargarlos en la consulta
        public static DataTable BuscarTodosEmpleados()
        {
            IEmpleadoAD empleadoAD = new EmpleadoAD();

            return empleadoAD.BuscarTodos();
        }
    }
}
