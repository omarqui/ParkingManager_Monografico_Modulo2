using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    public interface ITurnoAD
    {
        int Aperturar(Turno turno, SqlTransaction transaction = null);

        int Cerrar(Turno turno, SqlTransaction transaction = null);

        Turno BuscarPorID(int id);
        

    }
}
