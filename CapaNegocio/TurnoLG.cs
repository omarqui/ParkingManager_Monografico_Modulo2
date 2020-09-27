using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class TurnoLG
    {
        public static int BuscarSecuenciaTurno()
        {
            TurnoAD funcionesTurno = new TurnoAD();
            return funcionesTurno.ObtenerSecuencia();
        }

        public static int AperturarTurno(Turno turno)
        {
            TurnoAD funcionesTurno = new TurnoAD();
            return funcionesTurno.Aperturar(turno);
        }


        public static DataTable BuscarTurnos()
        {
            TurnoAD funcionesTunro = new TurnoAD();
            return funcionesTunro.BuscarTodos();
        }

        public static Turno EstaTurnoAbiertoEmpleado(int idEmpleadoTurno)
        {
            TurnoAD funcionesTunro = new TurnoAD();            
            return funcionesTunro.BuscarUltimoTurnoAbiertoEmpleado(idEmpleadoTurno);
        }

        public static int CerrarTurno(Turno turnoCerrar)
        {
            TurnoAD funcionesTurno = new TurnoAD();
            return funcionesTurno.Cerrar(turnoCerrar);
        }

        public static Turno BuscarTurnoPorID(int idTurnoAbierto)
        {
            TurnoAD funcionesTurno = new TurnoAD();
            return funcionesTurno.BuscarPorID(idTurnoAbierto);
        }
    }
}
