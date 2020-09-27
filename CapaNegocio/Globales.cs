using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Globales
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
                    if (_turno == null)
                    {
                        Turno turno = new Turno(Empleado.IdEmpleado, 100);
                        int idTurno = turnoRepositorio.Aperturar(turno);
                        if (idTurno > 0)
                            _turno = turnoRepositorio.BuscarPorID(idTurno);
                    }
                }
                return _turno;
            }
        }

        private static Empleado _empleado;
        public static Empleado Empleado
        {
            get
            {
                if (_empleado == null)
                {
                    _empleado = EmpleadoLG.BuscarEmpleado(1);
                }
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
