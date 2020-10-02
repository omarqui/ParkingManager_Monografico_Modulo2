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

        public static DataTable BuscarTurnos(int? idTurno, DateTime fechaDesde, DateTime fechaHasta, bool? estaAbierto)
        {
            TurnoAD funcionesTunro = new TurnoAD();
            return funcionesTunro.BuscarTodos(idTurno, fechaDesde, fechaHasta, estaAbierto);
        }

        public static Turno BuscarUltimoTurnoAbiertoEmpleado(int idEmpleado)
        {
            TurnoAD funcionesTunro = new TurnoAD();            
            return funcionesTunro.BuscarUltimoTurnoAbiertoEmpleado(idEmpleado);
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

        public static decimal BuscarSumatoriaCierreTurno(int idTurno)
        {
            TurnoAD funcionesTurno = new TurnoAD();
            return funcionesTurno.BuscarSumatoriaCierreTurno(idTurno);            
        }

        public static DataTable BuscarTurnoImpresion(int idTurno)
        {
            TurnoAD funcionesTurno = new TurnoAD();
            return funcionesTurno.BuscarTurnoImpresion(idTurno);
        }

        public static DatosReporte ImprimirTurno(int idTurno)
        {
            return new DatosReporte()
            {
                NombreReporte = "RptTurno",
                Datos = new Dictionary<string, DataTable>()
                {
                    {"Turno",  BuscarTurnoImpresion(idTurno)}
                }
            };
        }
    }
}
