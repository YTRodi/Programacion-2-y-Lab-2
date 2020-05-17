using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CentralitaHerencia;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasDelSistema
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void ListarClasesInstanciadasTest()
        {
            //Arrange
            Centralita centralita = new Centralita("Yago Center");

            //Assert
            Assert.IsInstanceOfType(centralita.Llamadas, typeof(List<Llamada>));
            Assert.IsNotNull(centralita.Llamadas);//veo si se instanció la lista o no.
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LlamadaLocalRepetidaTest()
        {
            //Arrange
            //pOrigen y pDestino igual.
            Centralita central = new Centralita("Yago Center");
            Local llamadaLocal01 = new Local("42121743", 50f, "1136153288", 5000f);
            Local llamadaLocal02 = new Local("42121743", 15f, "1136153288", 1000f);

            //Art
            central += llamadaLocal01;
            central += llamadaLocal02;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LlamadaProvincialRepetidaTest()
        {
            //Arrange
            //pOrigen y pDestino igual.
            Centralita central = new Centralita("Yago Center");
            Provincial llamadaProvincial01 = new Provincial("12345678", Provincial.Franja.Franja_3, 50f, "42121743");
            Provincial llamadaProvincial02 = new Provincial("12345678", Provincial.Franja.Franja_1, 100f, "42121743");

            //Art
            central += llamadaProvincial01;
            central += llamadaProvincial02;

            //Assert
        }

        [TestMethod]
        public void SonLlamadasIgualesTest()
        {
            //Arrange
            //Todos mismo datos de origen y destino.
            Centralita central = new Centralita("Yago Center");
            Local llamadaLocal01 = new Local("42121743", 50f, "1136153288", 5000f);
            Local llamadaLocal02 = new Local("42121743", 15f, "1136153288", 1000f);
            Provincial llamadaProvincial01 = new Provincial("42121743", Provincial.Franja.Franja_3, 50f, "1136153288");
            Provincial llamadaProvincial02 = new Provincial("42121743", Provincial.Franja.Franja_1, 100f, "1136153288");

            //Act

            //Assert
            Assert.IsTrue(llamadaLocal01 == llamadaLocal02);
            Assert.IsTrue(llamadaProvincial01 == llamadaProvincial02);
            Assert.IsFalse(llamadaLocal01 == llamadaProvincial01);
        }

    }
}
