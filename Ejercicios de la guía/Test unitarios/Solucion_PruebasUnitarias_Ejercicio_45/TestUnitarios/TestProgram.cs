using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class TestProgram
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestMiException()
        {
            OtraClase otraClase = new OtraClase();
            otraClase.OtroMetodoInstancia();//provoco la excepción.
        }
    }
}
