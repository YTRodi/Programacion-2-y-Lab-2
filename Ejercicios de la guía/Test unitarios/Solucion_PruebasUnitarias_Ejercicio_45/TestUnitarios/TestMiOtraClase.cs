using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Excepciones;

namespace TestUnitarios
{
    /// <summary>
    /// Test de la clase OtraClase.cs
    /// </summary>
    [TestClass]
    public class TestMiOtraClase
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestInstanciaMiClase()
        {
            //Arrange
			new MiClase();
        }

        [TestMethod]
        public void TestMiExceptionConMessage()
        {
            //Arrange
            MiExcepcion exPrueba = new MiExcepcion("Excepción desde la clase OtraClase.cs!");

            //Assert
            Assert.IsInstanceOfType(exPrueba,typeof(MiExcepcion));
        }
    }
}
