using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasDelSistema
{
    [TestClass]
    public class ClaseDeTest
    {
        [TestMethod]
        public void TestAgregarReceta()//usar el parcial 1
        {
            //Arrange
            Receta recetita = new Receta(50);
            Pera pera1 = new Pera("pera 1", 50, "Verde");
            Pera pera2 = new Pera("pera 2", 10, "Amarilla");
            //Act
            bool pudo = false;
            pudo = recetita + pera1;//true, hay espacio para la cantidad de ingrediente
            pudo = recetita + pera2;//false, no hay espacio.
            //Assert
            Assert.IsFalse(pudo);//el ultimo pudo tiene que dar false

            //try
            //{
            //    pudo = recetita + pera2;
            //}
            //catch (Exception e)
            //{
            //    Assert.IsInstanceOfType(e, typeof(ArgumentException));
            //}
        }
    }
}
