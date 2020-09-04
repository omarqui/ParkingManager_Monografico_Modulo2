using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;

namespace CapaDatosUnitTest
{
    [TestClass]
    public class ManejadorConexionTests
    {
        [TestMethod]
        public void ObtenerConexionTests()
        {
            Assert.IsNotNull(ManejadorConexion.Conexion);
        }
    }
}
