using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class Globales
    {
        private static Turno _turno;

        public static Turno Turno
        {
            get
            {
                RefrescarTurno();
                return _turno;
            }
        }

        public static void RefrescarTurno()
        {
            if (_turno == null)
            {
                _turno = TurnoLG.BuscarUltimoTurnoAbiertoEmpleado(Empleado.IdEmpleado);
                RefrescarFormPrincipal();
            }
        }

        private static Empleado _empleado;
        public static Empleado Empleado
        {
            get
            {
                RefrescarEmpleado();
                return _empleado;
            }
            set
            {
                _empleado = value;
            }
        }

        public static void RefrescarEmpleado()
        {
            if (_empleado == null)
            {
                _empleado = EmpleadoLG.BuscarEmpleado(1);
                RefrescarFormPrincipal();
            }
        }

        private static Configuracion _configuracion;

        internal static void LimpiarTurno()
        {
            _turno = null;
            RefrescarFormPrincipal();
        }

        public static Configuracion Configuracion
        {
            get
            {
                if (_configuracion == null)
                {
                    _configuracion = ConfiguracionLG.BuscarConfiguracionSistema();
                    RefrescarFormPrincipal();
                }
                return _configuracion;
            }
        }

        internal static void LimpiarConfiguracion()
        {
            _configuracion = null;
            RefrescarFormPrincipal();
        }

        private static void RefrescarFormPrincipal()
        {
            Program._formularioPrincipal.SetInformacionesGenerales(_turno,_empleado);
        }

        internal static bool ObligarAperturaTurno()
        {
            if (_turno == null)
            {
                var respuestaApertura = MessageBox.Show(
                    "Para continuar debe aperturar un turno, desea continuar?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuestaApertura == DialogResult.No)
                {
                    return false;
                }

                AbrirFormulario<frmTurno>.ejecutarSoloUnaVez(true);

                if (_turno == null)
                    return false;
            }

            return true;
        }
    }
}
