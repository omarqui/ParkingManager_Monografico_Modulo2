using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CobroParqueo
    {
        private UsoDeParqueo uso;

        public CobroParqueo()
        {

        }

        public CobroParqueo(UsoDeParqueo uso)
        {
            IdTurno = uso.IdTurno;
            IdUso = uso.IdUso;
            Fecha = uso.FechaSalida;
            TotalCobrado = uso.Total;
        }

        public CobroParqueo(UsoDeParqueo uso, decimal descuento, decimal montoPagado)
        {
            IdTurno = uso.IdTurno;
            IdUso = uso.IdUso;
            Fecha = uso.FechaSalida;
            Descuento = descuento;
            TotalCobrado = uso.Total - descuento;
            MontoPagado = montoPagado;
            Devuelta = montoPagado - (uso.Total - descuento);
        }

        public int IdCobro { get; set; }
        public int IdUso { get; set; }
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalCobrado { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Devuelta
        {
            get;
            set ;
        }
    }
}
