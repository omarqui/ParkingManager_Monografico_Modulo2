using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using Entidades;

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
    }
}
