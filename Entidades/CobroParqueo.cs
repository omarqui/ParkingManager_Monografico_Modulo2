using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CobroParqueo
    {
        public int IdCobro { get; set; }
        public int IdUso { get; set; }
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalCobrado { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Devuelta { get; set; }
    }
}
