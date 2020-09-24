using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using Entidades;
using System.Data.SqlClient;

namespace CapaDatosUnitTest
{
    [TestClass]
    public class ConfiguracionADTests
    {
        [TestMethod]
        public void BuscarConfiguracionTest()
        {
            var repositorio = new ConfiguracionAD();
            Assert.IsNotNull(repositorio.Buscar());
        }

        [TestMethod]
        public void GuardarTests()
        {
            using (var conn = ManejadorConexion.Conexion)
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    var repositorio = new ConfiguracionAD(conn);
                    var configuracion = new Configuracion()
                    {
                        CantidadParqueos = 10,
                        DireccionEmpresa = "Moca 2",
                        NombreEmpresa = "Soy una empresa",
                        PrecioPorHora = 15,
                        TelefonoEmpresa = "1234567890"
                    };

                    Assert.AreEqual(repositorio.Guardar(configuracion, transaction), 1);

                    transaction.Rollback();
                }
            }
        }        
    }
}
