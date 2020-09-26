using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatosUnitTest
{
    [TestClass]
    public class CobroParqueoDATests
    {
        [TestMethod]
        public void BuscarPorIDTests()
        {
            var repositorio = new CobroParqueoDA();
            Assert.IsNotNull(repositorio.BuscarPorID(1));
        }

        [TestMethod]
        public void BuscarPorIdUsoParqueoTests()
        {
            var repositorio = new CobroParqueoDA();
            Assert.IsNotNull(repositorio.BuscarPorIdUsoParqueo(1));
        }

        public void BuscarTodosTests()
        {
            var repositorio = new CobroParqueoDA();
            Assert.IsInstanceOfType(repositorio.BuscarTodos(),typeof(DataSet));
        }

        [TestMethod]
        public void GuardarTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var repositorio = new CobroParqueoDA(conn);
                    var cobro = new CobroParqueo()
                    {
                        IdUso = 2,
                        IdTurno = 1,
                        Fecha = DateTime.Now,
                        TotalCobrado = 1000,
                        Descuento = 10,
                        MontoPagado = 1500,
                        Devuelta = 500
                    };

                    Assert.AreEqual(repositorio.Guardar(cobro, transaction), 1);

                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void ObtenerSecuenciaTests()
        {
            var repositorio = new CobroParqueoDA();
            Assert.IsNotNull(repositorio.ObtenerSecuencia());
        }
    }
}
