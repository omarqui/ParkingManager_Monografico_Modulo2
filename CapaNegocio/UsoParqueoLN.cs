using CapaDatos;
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
        static readonly UsoDeParqueoAD repositorio = new UsoDeParqueoAD();

        public static bool AperturarUso()
        {
            int filasAfectadas = repositorio.AperturarUso(ConfiguracionLG.Configuracion);
            return filasAfectadas > 0;
        }

        public bool BuscarPorID(int id)
        {
            throw new Exception();
        }

        public bool CerrarUso(int id)
        {
            throw new Exception();
        }

        public DataTable BuscarTodos()
        {
            throw new Exception();
        }

        public int BuscarCantidadParqueoDisponibles()
        {
            throw new Exception();
        }

        public bool CancelarUso()
        {
            throw new Exception();
        }
    }
}
