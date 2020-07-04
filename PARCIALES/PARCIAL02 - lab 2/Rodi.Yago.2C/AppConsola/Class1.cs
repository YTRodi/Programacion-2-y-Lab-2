using Archivos_y_serializacion;
using Entidades_Abstractas;
using Entidades_Instanciables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace AppConsola
{
    public class Class1
    {
        //Arrange
        Clinica miClinica = new Clinica("Clínica Calchaquí");

        Paciente pUno = new Paciente("Rodi", "Yago", 21, Persona.ESexo.Masculino, "Calle falsa 123", 41448581, Paciente.EObraSocial.CoberturaCompleta);
        Especialista e01 = new Especialista("Alcor", "Noque", 55, Persona.ESexo.Masculino, "Av. Brasil 555", 88882222, Especialista.EEspecialidad.Psicologia);

        Turno t1 = new Turno(pUno, e01, "Esta re loco", DateTime.Now);

        IArchivo <Turno> serTurnoBin = new PuntoDat<Turno>();
        bool pudoGuardar = false;

        ////Act
        //miClinica += t1;
        //    pudoGuardar = serTurnoBin.Guardar(this.pathTurno, t1);

        ////Assert
        //Assert.IsTrue(pudoGuardar);
    }
}
