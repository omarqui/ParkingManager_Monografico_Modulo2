using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using Entidades;
using System.Data.SqlClient;

namespace CapaDatosUnitTest
{
    [TestClass]
    public class TurnoADTests
    {
        [TestMethod]
        public void BuscarPorIDTests()
        {
            var turno = new TurnoAD();
            Assert.IsNotNull(turno.BuscarPorID(1));
        }

        [TestMethod]
        public void AperturarTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var turnoRepositorio = new TurnoAD(conn);
                    var turno = new Turno()
                    {
                        IdEmpleado = 1,
                        MontoApertura = 1000
                    };

                    Assert.AreEqual(turnoRepositorio.Aperturar(turno, transaction), 1);

                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void CerrarTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var turnoRepositorio = new TurnoAD(conn);
                    var turno = new Turno()
                    {
                        IdTurno = 1,
                        MontoCobrado = 15000,
                        MontoEntregado = 15050,
                        MontoDiferencia = 50
                    };

                    Assert.AreEqual(turnoRepositorio.Cerrar(turno, transaction), 1);

                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void ObtenerSecuenciaTests()
        {
            var empleadoRepositorio = new EmpleadoAD();
            Assert.IsNotNull(empleadoRepositorio.ObtenerSecuencia());
        }
    }
}
