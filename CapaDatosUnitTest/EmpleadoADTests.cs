using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using Entidades;
using System.Data.SqlClient;

namespace CapaDatosUnitTest
{
    [TestClass]
    public class EmpleadoADTests
    {
        [TestMethod]
        public void EsUsuarioValidoTests()
        {
            var empleado = new EmpleadoAD();
            Assert.IsTrue(empleado.EsUsuarioValido("admin", "123"));
        }

        [TestMethod]
        public void BuscarPorIDTests()
        {
            var empleado = new EmpleadoAD();
            Assert.IsNotNull(empleado.BuscarPorID(1));
        }

        [TestMethod]
        public void BuscarPorUsuarioTests()
        {
            var empleado = new EmpleadoAD();
            Assert.IsNotNull(empleado.BuscarPorUsuario("Admin"));
        }

        [TestMethod]
        public void GuardarTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var empleadoRepositorio = new EmpleadoAD(conn);
                    var empleado = new Empleado()
                    {
                        Cedula = "123",
                        Celular = "4546",
                        Clave = "123",
                        Direccion = "klk",
                        Nombre = "jua",
                        Usuario = "kd"
                    };

                    Assert.AreEqual(empleadoRepositorio.Guardar(empleado, transaction), 1);

                    transaction.Rollback();
                }
            }
        }

        [TestMethod]
        public void ObtenerSecuenciaTests()
        {
            var empleadoRepositorio = new EmpleadoAD();
            Assert.IsNotNull(empleadoRepositorio.ObtenerSecuencia());
            Assert.IsNotNull(empleadoRepositorio.ObtenerSecuencia());
        }
    }
}
