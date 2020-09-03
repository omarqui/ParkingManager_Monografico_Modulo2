using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class TurnoEN
    {
        public int IdTurno { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime  FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public float MontoApertura { get; set; }
        public float MontoCobrado { get; set; }
        public float MontoEntregado { get; set; }
        public float MontoDiferencia { get; set; }
    }
}
