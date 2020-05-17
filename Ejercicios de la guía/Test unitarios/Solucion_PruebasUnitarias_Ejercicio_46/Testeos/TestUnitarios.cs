using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;

namespace Testeos
{
    [TestClass]
    public class TestUnitarios
    {   
        [TestMethod]
        public void TestListaVehiculosInstanciada()
        {
            //Arrange
            Competencia compeDeAutos = new Competencia(15, 2, Competencia.TipoCompetencia.F1);

            //Act
            //Assert
            Assert.IsInstanceOfType(compeDeAutos.ListaVehiculos, typeof(List<VehiculoDeCarrera>));
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AgregarAutoEnCompetenciaMotoCross()
        {
            //Arrange
            Competencia competenciaMotoCross = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoPrueba = new AutoF1(15, "Yaggi's", 200);
            bool agregoACompetencia = false;

            //Act
            agregoACompetencia = competenciaMotoCross + autoPrueba;

            //Assert
            Assert.IsFalse(agregoACompetencia);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AgregarMotoCrossEnCompetenciaAutoF1()
        {
            //Arrange
            Competencia competenciaAutosF1 = new Competencia(15, 2, Competencia.TipoCompetencia.F1);
            MotoCross motoPrueba = new MotoCross(15, "Yaggi's", 200);
            bool agregoACompetencia = false;

            //Act
            agregoACompetencia = competenciaAutosF1 + motoPrueba;

            //Assert
            Assert.IsFalse(agregoACompetencia);
        }

        [TestMethod]
        public void TestVehiculoEnListaRepetido()
        {
            //Arrange
            Competencia competenciaMotoCross = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoPrueba = new MotoCross(15, "Yaggi's", 200);
            bool agrego = false;
            bool agregoRepetido = false;

            //Act
            agrego = competenciaMotoCross + motoPrueba;
            agregoRepetido = competenciaMotoCross + motoPrueba;//lo repeto

            //Assert
            Assert.IsFalse(agregoRepetido);
            CollectionAssert.Contains(competenciaMotoCross.ListaVehiculos, motoPrueba);
        }

        [TestMethod]
        public void TestEliminarVehiculo()
        {
            //Arrange
            Competencia competenciaMotoCross = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoPrueba = new MotoCross(15, "Yaggi's", 200);
            bool agrego = false;
            bool elimino = false;

            //Act
            agrego = competenciaMotoCross + motoPrueba;
            elimino = competenciaMotoCross - motoPrueba;

            //Assert
            Assert.IsTrue(elimino);
            CollectionAssert.DoesNotContain(competenciaMotoCross.ListaVehiculos, motoPrueba);
            //CollectionAssert.Contains(competenciaMotoCross.ListaVehiculos, motoPrueba);
        }
    }
}
