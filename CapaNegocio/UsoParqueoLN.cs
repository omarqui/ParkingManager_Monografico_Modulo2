using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsoParqueoLN
    {
        public static bool AperturarUso()
        {
            UsoDeParqueoAD repositorio = new UsoDeParqueoAD();
            int filasAfectadas = repositorio.AperturarUso(Globales.Turno.IdTurno);
            return filasAfectadas > 0;
        }

        public static UsoDeParqueo BuscarPorID(int id)
        {
            UsoDeParqueoAD repositorio = new UsoDeParqueoAD();
            return repositorio.BuscarPorID(id);
        }

        public static UsoDeParqueo BuscarPorIDParaCerrar(int id)
        {
            UsoDeParqueo uso = BuscarPorID(id);
            if (uso == null)
            {
                throw new ExepcionPersonalida("Ticket no encontrado");
            }

            if (!uso.EstaActivo)
            {
                throw new ExepcionPersonalida("Este ticket no esta activo");
            }

            if (uso.Cobro != null)
            {
                throw new ExepcionPersonalida("Este ticket ya fue cobrado");
            }

            DateTime fechaCierre = DateTime.Now;
            uso.FechaSalida = fechaCierre;
            TimeSpan span = fechaCierre.Subtract(uso.FechaEntrada);
            uso.TiempoUso = decimal.Round(Convert.ToDecimal(span.TotalMinutes), 2);
            uso.Total = decimal.Round(uso.TiempoUso * uso.PrecioPorMinuto, 2);
            uso.Cobro = new CobroParqueo(uso);
            return uso;
        }

        public static bool CerrarUso(UsoDeParqueo uso)
        {
            UsoDeParqueoAD repositorio = new UsoDeParqueoAD();
            int filasAfectadas = repositorio.CerrarUso(uso);

            //CobroParqueo cobro = new CobroParqueo(uso,descuento,montoPagado);
            CobroParqueoDA cobroRepositorio = new CobroParqueoDA();

            int filasAfectadasCobro =cobroRepositorio.Guardar(uso.Cobro);

            return filasAfectadas > 0 && filasAfectadasCobro > 0;
        }

        public static DataTable BuscarTodos(
            DateTime? desde = null,
            DateTime? hasta = null,
            int? idCajero = null,
            string estado = null,
            string textoAbierto = null)
        {
            UsoDeParqueoAD repositorio = new UsoDeParqueoAD();
            
            
            if (idCajero == 0) idCajero = null;
            if (estado == string.Empty) estado = null;
            if (textoAbierto == string.Empty) textoAbierto = null;

            return repositorio.BuscarTodos(
                desde,
                hasta,
                idCajero,
                estado,
                textoAbierto);
        }

        public static int BuscarCantidadParqueoDisponibles()
        {
            UsoDeParqueoAD repositorio = new UsoDeParqueoAD();
            return repositorio.BuscarCantidadParqueoDisponibles();
        }

        public static bool CancelarUso(int id)
        {
            UsoDeParqueoAD repositorio = new UsoDeParqueoAD();
            int filasAfectadas = repositorio.CancelarUso(id);
            return filasAfectadas > 0;
        }
    }
}
