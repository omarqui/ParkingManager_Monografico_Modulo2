using System;
using System.Collections.Generic;
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
    }
}
