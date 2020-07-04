using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades_Abstractas;
using Excepciones;
using Archivos_y_serializacion;

namespace Entidades_Instanciables
{
    [Serializable]
    public class Clinica : Institucion
    {
        #region Atributos
        private List<Turno> lstTurnos;
        private List<Paciente> lstPacientes;
        private List<Especialista> lstEspecialistas;

        private List<Thread> cicloTurnos;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la lista de Turnos.
        /// </summary>
        public List<Turno> Turnos
        {
            get { return this.lstTurnos; }
            set { this.lstTurnos = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la lista de Pacientes.
        /// </summary>
        public List<Paciente> ListaPacientes
        {
            get { return this.lstPacientes; }
            set { this.lstPacientes = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la lista de Especialistas.
        /// </summary>
        public List<Especialista> ListaEspecialistas
        {
            get { return this.lstEspecialistas; }
            set { this.lstEspecialistas = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Clinica.
        /// </summary>
        public Clinica()
        {

        }
        /// <summary>
        /// Constructor que llama a la base e inicializa las listas
        ///  Turnos, ListaPacientes, ListaEspecialistas y cicloTurnos.
        /// </summary>
        /// <param name="razonSocial"></param>
        public Clinica(string razonSocial) : base(razonSocial)
        {
            this.Turnos = new List<Turno>();
            this.ListaPacientes = new List<Paciente>();
            this.ListaEspecialistas = new List<Especialista>();

            this.cicloTurnos = new List<Thread>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para leer Pacientes de un archivo .xml
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Una lista de los pacientes del archivo .xml</returns>
        public static List<Paciente> LeerPacientesXML(string path)
        {
            IArchivo<List<Paciente>> archivoXml = new XML<List<Paciente>>();

            archivoXml.Leer(path, out List<Paciente> lstPaciente);

            return lstPaciente;
        }

        /// <summary>
        /// Método para leer Especialistas de un archivo .xml
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Una lista de los especialistas del archivo .xml</returns>
        public static List<Especialista> LeerEspecialistasXML(string path)
        {
            IArchivo<List<Especialista>> archivoXml = new XML<List<Especialista>>();

            archivoXml.Leer(path, out List<Especialista> lstEspecialistas);

            return lstEspecialistas;
        }

        /// <summary>
        /// Método que finaliza los hilos que siguen en ejecución de la lista cicloTurnos.
        /// </summary>
        public void FinTurnos()
        {
            foreach (Thread hilo in this.cicloTurnos)
            {
                if (hilo.IsAlive)
                    hilo.Abort();
            }
        }

        /// <summary>
        /// Método que verifca si el turno ya se encuentra en la lista.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        private bool TurnoEstaEnLista(Clinica c, Turno t)
        {
            bool pasoVerificacion = false;

            //Si el paciente y el especialista no estan en la clínica, no va a asignarle turno.
            if (c.ListaPacientes.Contains(t.Paciente) && c.ListaEspecialistas.Contains(t.Especialista))
            {
                pasoVerificacion = true;
            }

            return pasoVerificacion;
        }

        /// <summary>
        /// Método que agrega a la lista un turno.
        /// </summary>
        /// <param name="t"></param>
        private void AgregarTurno(Turno t)
        {
            this.Turnos.Add(t);
        }
        #endregion

        #region Operaciones
        //Clinica - Paciente
        /// <summary>
        /// Sobrecarga del operador == entre una:
        ///  Clinica y Paciente.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns>True: Si el paciente ya se encuentra en la clínica.</returns>
        public static bool operator ==(Clinica c, Paciente p)
        {
            bool pEstaEnClinica = false;

            foreach (Paciente item in c.ListaPacientes)
            {
                if (item == p)
                {
                    pEstaEnClinica = true;
                    break;
                }
            }

            return pEstaEnClinica;
        }

        /// <summary>
        /// Sobrecarga del operador != entre una:
        ///  Clinica y Paciente.
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns>True: Si el paciente no se encuentra en la clínica.</returns>
        public static bool operator !=(Clinica c, Paciente p)
        {
            return !(c == p);
        }

        /// <summary>
        /// Sobrecarga del operador == entre una:
        ///  Clinica y Especialista.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        /// <returns>True: Si el Especialista ya se encuentra en la clínica.</returns>
        public static bool operator ==(Clinica c, Especialista e)
        {
            bool eEstaEnClinica = false;

            foreach (Especialista item in c.ListaEspecialistas)
            {
                if (item == e)
                    eEstaEnClinica = true;
            }

            return eEstaEnClinica;
        }

        /// <summary>
        /// Sobrecarga del operador != entre una:
        ///  Clinica y Especialista.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        /// <returns>True: Si el Especialista no se encuentra en la clínica.</returns>
        public static bool operator !=(Clinica c, Especialista e)
        {
            return !(c == e);
        }

        /// <summary>
        /// Sobrecarga del operador == entre una:
        ///  Clinica y Turno.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="t"></param>
        /// <returns>True: Si el Turno ya se encuentra en la clínica.</returns>
        public static bool operator ==(Clinica c, Turno t)
        {
            bool tEstaEnClinica = false;

            foreach (Turno item in c.Turnos)
            {
                if (item == t)
                {
                    tEstaEnClinica = true;
                    break;
                }
            }

            return tEstaEnClinica;
        }

        /// <summary>
        /// Sobrecarga del operador != entre una:
        ///  Clinica y Turno.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="t"></param>
        /// <returns>True: Si el Turno no se encuentra en la clínica.</returns>
        public static bool operator !=(Clinica c, Turno t)
        {
            return !(c == t);
        }

        /// <summary>
        /// Sobrecargar del operador +.
        /// Agrega un paciente a la clínica (ListaPacientes).
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns>Una clínica</returns>
        public static Clinica operator +(Clinica c, Paciente p)
        {
            if (c != p)
                c.ListaPacientes.Add(p);

            return c;
        }

        /// <summary>
        /// Sobrecargar del operador +.
        /// Agrega un especialista a la clínica (ListaEspecialistas).
        /// </summary>
        /// <param name="c"></param>
        /// <param name="e"></param>
        /// <returns>Una clínica</returns>
        public static Clinica operator +(Clinica c, Especialista e)
        {
            if (c != e)
                c.ListaEspecialistas.Add(e);

            return c;
        }

        /// <summary>
        /// Sobrecarga del operador +.
        /// 
        /// -Primero: Verifica si el paciente y el especialista están en la clínica.
        /// 
        /// -Segundo: Verifica si el turno no está en la lista. 
        /// 
        /// -Tercero: Agrega un turno a la clínica (ListaTurnos).
        /// 
        /// Verificando que que cumpla:
        ///  Si el sexo del paciente es masculino y quiere sacar turno para un/una obstetra/Ginecologa no pueda.
        ///  Si la edad del paciente es mayor o igual a 14 años no pueda sacar turno para Pediatría.
        /// Casos contrarios, lanzará una excepción del tipo TurnoException, especificando el error.
        /// 
        /// -Cuarto: inicializará un hilo de turno que invocará el método "MockCicloDeVida()" de la clase Turno.
        /// 
        /// -Quinto: Agrega el hilo creado a la lista de hilos de clinica (cicloTurnos).
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="t"></param>
        /// <returns>Una clínica.</returns>
        public static Clinica operator +(Clinica c, Turno t)
        {
            if (c.TurnoEstaEnLista(c, t))
            {
                if (c != t)
                {
                    if (t.Paciente.Sexo == Persona.ESexo.Masculino && t.Especialista.Campo == Especialista.EEspecialidad.Obtetricia ||
                        t.Paciente.Sexo == Persona.ESexo.Masculino && t.Especialista.Campo == Especialista.EEspecialidad.Ginecologia)
                    {
                        throw new TurnoException($"El paciente: {t.Paciente.Apellido} no puede pedir turno para {t.Especialista.Campo} por que es un hombre.");
                    }
                    else if (t.Paciente.Edad >= 14 && t.Especialista.Campo == Especialista.EEspecialidad.Pediatria)
                    {
                        throw new TurnoException($"El/La paciente: {t.Paciente.Apellido} no puede pedir turno para {t.Especialista.Campo} por que tiene {t.Paciente.Edad} años." +
                            $"\nPara este campo sólo se aceptan pacientes de hasta 14 años inclusive.");
                    }
                    else
                    {
                        //c.Turnos.Add(t);
                        c.AgregarTurno(t);

                        //Agregar el mock ciclo de vida al ciclo de turnos.
                        Thread hiloTurno = new Thread(new ThreadStart(t.MockCicloDeVida));

                        c.cicloTurnos.Add(hiloTurno);

                        hiloTurno.Start();
                    }
                }
                else
                {
                    throw new TurnoException("El turno ya se encuentra en la clínica");
                }
            }

            return c;
        }
        #endregion
    }
}
