using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Globales
    {
        private static Turno _turno;

        public static Turno Turno
        {
            get
            {
                if (_turno == null)
                {
                    TurnoAD turnoRepositorio = new TurnoAD();
                    _turno = turnoRepositorio.BuscarUltimoTurnoAbiertoEmpleado(Empleado.IdEmpleado);
                }
                return _turno;
            }
        }

        private static Empleado _empleado;
        public static Empleado Empleado
        {
            get
            {
                return _empleado;
            }
            set
            {
                _empleado = value;
            }
        }

        private static Configuracion _configuracion;
        public static Configuracion Configuracion
        {
            get
            {
                if (_configuracion == null)
                {
                    _configuracion = ConfiguracionLG.BuscarConfiguracionSistema();
                }
                return _configuracion;
            }
        }
    }
}
