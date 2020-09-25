using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using Entidades;
using System.Data.SqlClient;

namespace CapaDatosUnitTest
{
    [TestClass]
    public class UsoDeParqueoADTests
    {
        [TestMethod]
        public void BuscarCantidadParqueoDisponiblesTests()
        {
            var repositorio = new UsoDeParqueoAD();
            Assert.IsNotNull(repositorio.BuscarCantidadParqueoDisponibles());
        }

        [TestMethod]
        public void BuscarPorIDTests()
        {
            var repositorio = new UsoDeParqueoAD();
            Assert.IsNotNull(repositorio.BuscarPorID(1));
        }


        [TestMethod]
        public void BuscarTodosTests()
        {
            var repositorio = new UsoDeParqueoAD();
            Assert.IsNotNull(repositorio.BuscarTodos());
        }

        [TestMethod]
        public void CancelarUsoTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var repositorio = new UsoDeParqueoAD();
                    Assert.IsNotNull(repositorio.CancelarUso(1));
                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void AperturarUsoTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var repositorio = new UsoDeParqueoAD(conn);

                    Assert.IsNotNull(repositorio.AperturarUso(1, transaction));

                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void CerrarUsoTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var repositorio = new UsoDeParqueoAD(conn);
                    var usoParqueo = new UsoDeParqueo()
                    {
                        IdUso = 1,
                        FechaSalida = DateTime.Now,
                        Total = 500
                    };

                    Assert.IsNotNull(repositorio.CerrarUso(usoParqueo, transaction));

                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void ObtenerSecuenciaTests()
        {
            var repositorio = new UsoDeParqueoAD();
            Assert.IsNotNull(repositorio.ObtenerSecuencia());
        }
    }
}
