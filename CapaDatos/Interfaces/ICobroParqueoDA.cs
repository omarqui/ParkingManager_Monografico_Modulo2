using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    interface ICobroParqueoDA
    {
        int Guardar(CobroParqueo cobro, SqlTransaction transaction = null);

        CobroParqueo BuscarPorID(int id);

        DataTable BuscarTodos();

        CobroParqueo BuscarPorIdUsoParqueo(int id);
    }
}
