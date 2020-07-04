using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos_y_serializacion;
using Entidades_Abstractas;
using Entidades_Instanciables;
using Excepciones;
using Métodos_de_extensión;

namespace Tests
{
    [TestClass]
    public class TestClinica
    {
        [TestMethod]
        public void TAltaTurno()
        {
            //Arrange
            Clinica miClinica = new Clinica("Clínica Calchaquí");

            Paciente p1 = new Paciente("Rodi", "Yago", 21, Persona.ESexo.Masculino, "Calle falsa 123", 41448581, Paciente.EObraSocial.CoberturaCompleta);
            Especialista e1 = new Especialista("Alcor", "Noque", 55, Persona.ESexo.Masculino, "Av. Brasil 555", 88882222, Especialista.EEspecialidad.Psicologia);
            Turno t1 = new Turno(p1, e1, "Esta re loco", DateTime.Now);

            //Act
            miClinica += p1; //Tienen que estar ingresados en mi clínica si o si para poder darles turno.
            miClinica += e1;

            miClinica += t1; //Alta de turno.

            //Assert
            CollectionAssert.Contains(miClinica.Turnos, t1); //Si contiene el turno, es pq se dió de alta perfectamente.
        }

        [TestMethod]
        public void TAltaPaciente()
        {
            //Arrange
            Clinica miClinica = new Clinica("Clínica Calchaquí");

            Paciente p1 = new Paciente("Rodi", "Yago", 21, Persona.ESexo.Masculino, "Calle falsa 123", 41448581, Paciente.EObraSocial.CoberturaCompleta);

            //Act
            miClinica += p1; //Tienen que estar ingresados en mi clínica si o si para poder darles turno.

            //Assert
            CollectionAssert.Contains(miClinica.ListaPacientes, p1); //Si contiene el turno, es pq se dió de alta perfectamente.
        }

        [TestMethod]
        public void TAltaEspecialista()
        {
            //Arrange
            Clinica miClinica = new Clinica("Clínica Calchaquí");

            Especialista e1 = new Especialista("Alcor", "Noque", 55, Persona.ESexo.Masculino, "Av. Brasil 555", 88882222, Especialista.EEspecialidad.Psicologia);

            //Act
            miClinica += e1; //Tienen que estar ingresados en mi clínica si o si para poder darles turno.

            //Assert
            CollectionAssert.Contains(miClinica.ListaEspecialistas, e1); //Si contiene el turno, es pq se dió de alta perfectamente.
        }
    }
}
