using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsoDeParqueo
    {
        public int IdUso { get; set; }
        public int IdTurno { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal TiempoUso { get; set; }
        public decimal PrecioPorMinuto { get; set; }
        public decimal Total { get; set; }
    }
}
