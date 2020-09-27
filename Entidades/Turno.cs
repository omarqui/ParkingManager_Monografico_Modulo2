using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        public Turno()
        {

        }

        public Turno(int idEmpleado, decimal montoApertura)
        {
            IdEmpleado = idEmpleado;
            MontoApertura = montoApertura;
        }

        public int IdTurno { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime  FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public decimal MontoApertura { get; set; }
        public decimal MontoCobrado { get; set; }
        public decimal MontoEntregado { get; set; }
        public decimal MontoDiferencia { get; set; }
    }
}
