using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Métodos_de_extensión;
using Entidades_Instanciables;
using Entidades_Abstractas;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de TestExcepciones
    /// </summary>
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TArchivoException()
        {
            /*Para que se produzca la excepción la extensión del archivo no tiene que ser .txt*/
            string datos = "aguante mortal kombat";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\aguante.xml";

            /*La primera vez dará error, ya que el método Guardar si no encuentra el directorio lo crea.
             Y cuando lo cree, el método verá que no es de extensión .txt y lanzará la excepción.*/
            GyLString.Guardar(datos, path);
        }

        [TestMethod]
        [ExpectedException(typeof(TurnoException))]
        public void TTurnoException()
        {
            /*Explicación: Si quiero dar de alta un turno en mi clínica y el paciente tiene 14 años o más y el especialista 
             su campo es pediatria, no va a darse ese turno.*/

            //Arrange
            Clinica miClinica = new Clinica("Clínica Calchaquí");

            Paciente p1 = new Paciente("Rodi", "Yago", 21, Persona.ESexo.Masculino, "Calle falsa 123", 41448581, Paciente.EObraSocial.CoberturaCompleta);
            Especialista e1 = new Especialista("Doctora", "Juguetes", 35, Persona.ESexo.Femenino, "Av. Brasil 555", 88882222, Especialista.EEspecialidad.Pediatria);
            Turno t1 = new Turno(p1, e1, "Esta re loco", DateTime.Now);

            //Act
            miClinica += p1; //Tienen que estar ingresados en mi clínica si o si para poder darles turno.
            miClinica += e1;


            miClinica += t1; //Cuando intento agregar el turno a la clínica, hay varias condiciones para que esto pueda darse.
        }
    }
}
