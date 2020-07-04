using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Instanciables;
using Entidades_Abstractas;
using Archivos_y_serializacion;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de TestArchivos
    /// </summary>
    [TestClass]
    public class TestArchivos
    {
        #region Atributos
        private string pathTurnoXml = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TurnoX.xml";
        private string pathTurnoBin = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TurnoX.bin";
        #endregion

        [TestMethod]
        public void TSerializarTurnoXML()
        {
            //Arrange
            Clinica miClinica = new Clinica("Clínica Calchaquí");

            Paciente p1 = new Paciente("Rodi", "Yago", 21, Persona.ESexo.Masculino, "Calle falsa 123", 41448581, Paciente.EObraSocial.CoberturaCompleta);
            Especialista e1 = new Especialista("Alcor", "Noque", 55, Persona.ESexo.Masculino, "Av. Brasil 555", 88882222, Especialista.EEspecialidad.Psicologia);

            Turno t1 = new Turno(p1, e1, "Esta re loco", DateTime.Now);

            IArchivo<Turno> serTurnoXml = new XML<Turno>();
            bool pudoGuardarXml = false;

            //Act
            miClinica += t1;
            pudoGuardarXml = serTurnoXml.Guardar(this.pathTurnoXml, t1);

            //Assert
            Assert.IsTrue(pudoGuardarXml);
        }

        [TestMethod]
        public void TDeserializarTurnoXML()
        {
            //Arrange
            IArchivo<Turno> desTurnoXml = new XML<Turno>();
            bool pudoLeerXml = false;

            //Act
            pudoLeerXml = desTurnoXml.Leer(this.pathTurnoXml, out Turno turnoLeido);

            //Assert
            Assert.IsTrue(pudoLeerXml);
        }

        [TestMethod]
        public void TSerializarTurnoBin()
        {
            //Arrange
            Clinica miClinica = new Clinica("Clínica Calchaquí");

            Paciente p1 = new Paciente("Rodi", "Yago", 21, Persona.ESexo.Masculino, "Calle falsa 123", 41448581, Paciente.EObraSocial.CoberturaCompleta);
            Especialista e1 = new Especialista("Alcor", "Noque", 55, Persona.ESexo.Masculino, "Av. Brasil 555", 88882222, Especialista.EEspecialidad.Psicologia);

            Turno t1 = new Turno(p1, e1, "Esta re loco", DateTime.Now);

            IArchivo<Turno> serTurnoBin = new PuntoDat<Turno>();
            bool pudoGuardarBin = false;

            //Act
            miClinica += p1;
            miClinica += e1;

            miClinica += t1;
            pudoGuardarBin = serTurnoBin.Guardar(this.pathTurnoBin, t1);

            //Assert
            Assert.IsTrue(pudoGuardarBin);
        }

        [TestMethod]
        public void TDeserializarTurnoBin()
        {
            //Arrange
            IArchivo<Turno> desTurnoBin = new PuntoDat<Turno>();
            bool pudoLeerBin = false;

            //Act
            pudoLeerBin = desTurnoBin.Leer(this.pathTurnoBin, out Turno aux);

            //Assert
            Assert.IsTrue(pudoLeerBin);
        }
    }
}
