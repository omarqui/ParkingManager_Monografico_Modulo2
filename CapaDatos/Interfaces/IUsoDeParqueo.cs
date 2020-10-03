﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    interface IUsoDeParqueo
    {
        int AperturarUso(int idTurno, SqlTransaction transaction = null);

        UsoDeParqueo BuscarPorID(int id);

        int CerrarUso(UsoDeParqueo uso, SqlTransaction transaction = null);

        DataTable BuscarTodos(
            DateTime? desde = null,
            DateTime? hasta = null,
            int? idCajero = null,
            string estado = null,
            string textoAbierto = null);

        int BuscarCantidadParqueoOcupados();

        int CancelarUso(int idUso, SqlTransaction transaction = null);
    }
}
