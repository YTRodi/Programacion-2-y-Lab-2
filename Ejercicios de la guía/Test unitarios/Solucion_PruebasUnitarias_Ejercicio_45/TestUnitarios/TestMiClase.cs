using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class TestMiClase
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestLLamadaMetodoEstatico()
        {
            //Arrange
            MiClase.MetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestInstanciaMiClase()
        {
            //Arrange
            new MiClase();//instancio.
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMetodoInstancia()
        {
            //Arrange
            int num01 = 20;
            int num02 = 0;
            int resultado = num01 / num02; //provoco la excepción.
        }
    }
}
