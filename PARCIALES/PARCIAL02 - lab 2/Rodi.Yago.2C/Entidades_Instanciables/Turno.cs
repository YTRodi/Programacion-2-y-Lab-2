using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;
using Entidades_Instanciables;
using Entidades_Instanciables.Bases_de_datos;
using Archivos_y_serializacion;
using Métodos_de_extensión;

namespace Entidades_Instanciables
{
    [Serializable]
    public class Turno
    {
        #region Delegados y eventos
        /// <summary>
        /// Delegado que tiene como función hacer de callback.
        /// </summary>
        /// <param name="obj"></param>
        public delegate void DelegadoTurnoEstado(object obj);

        /// <summary>
        /// Evento que se encarga de infomar el cambio de estado del turno. 
        /// </summary>
        public event DelegadoTurnoEstado EventoPasaEstado;
        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerado que contine los tipos de Estado que tendrá un Turno.
        /// </summary>
        public enum EEstado { EnEspera, Atendiendo, Atendido }
        #endregion

        #region Atributos
        private int id;
        private Paciente paciente;
        private Especialista especialista;
        private EEstado estado;
        private string observacionesTurno;
        private DateTime fechaTurno;
        #endregion

        #region Properties

        //No va a serializar este campo a la hora de guardar el turno.
        [XmlIgnoreAttribute]
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Paciente que está pidió un turno.
        /// </summary>
        public Paciente Paciente
        {
            get { return this.paciente; }
            set { this.paciente = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Especialista que elegió el Paciente.
        /// </summary>
        public Especialista Especialista
        {
            get { return this.especialista; }
            set { this.especialista = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna el Estado del turno.
        /// </summary>
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna las observaciones que hizo el especialista en la consulta (turno).
        /// </summary>
        public string ObservacionesTurno
        {
            get { return this.observacionesTurno; }
            set { this.observacionesTurno = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que 
        /// retorna la fecha que se realizó la consulta (turno).
        /// </summary>
        public DateTime FechaTurno
        {
            get { return this.fechaTurno; }
            set { this.fechaTurno = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Turno.
        /// </summary>
        public Turno()
        {

        }

        /// <summary>
        /// Constructor que inicializa los campos:
        ///  Paciente, Especialista, observacionesTurno y fechaTurno.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <param name="observacionesTurno"></param>
        /// <param name="fechaTurno"></param>
        public Turno(Paciente p, Especialista e, string observacionesTurno, DateTime fechaTurno)
        {
            this.Paciente = p;
            this.Especialista = e;
            this.ObservacionesTurno = observacionesTurno;
            this.FechaTurno = fechaTurno;
        }


        /// <summary>
        /// 
        /// CONSTRUCTOR PARA TRAER EL TURNO DESDE LA BASE DE DATOS!!!!!
        /// INNER JOINS!!!!
        /// :D
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="p"></param>
        /// <param name="e"></param>
        public Turno(int id, Paciente p, Especialista e, string observacionesTurno, DateTime fechaTurno)
                : this(p, e, observacionesTurno, fechaTurno)
        {
            this.Id = id;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método que muestra algunos datos del turno cuando está
        /// en el estado: EnEspera.
        /// </summary>
        /// <returns></returns>
        public string MostrarTurnoSalaEspera()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"PACIENTE: {this.Paciente.Apellido} {this.Paciente.Nombre} DNI:{this.Paciente.DNI} // ");
            sb.AppendLine($"DOCTOR: {this.Especialista.Apellido} {this.Especialista.Nombre}");

            return sb.ToString();
        }

        /// <summary>
        /// Método que muestra algunos datos del turno cuando está
        /// en el estado: Atendiendo.
        /// </summary>
        /// <returns></returns>
        public string MostrarTurnoAtendiendo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.MostrarTurnoSalaEspera());
            sb.AppendLine($"// ESPECIALIDAD: {this.Especialista.Campo}");

            return sb.ToString();
        }

        /// <summary>
        /// Método que muestra algunos datos del turno cuando está
        /// en el estado: Atendido.
        /// </summary>
        /// <returns></returns>
        public string MostrarTurnosFinalizados()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Turno nroº: {this.Id} // Paciente: {this.Paciente.Apellido} {this.Paciente.Nombre} DNI: {this.Paciente.DNI} // Especialista: {this.Especialista.Apellido} DNI: {this.Especialista.DNI} CAMPO: {this.Especialista.Campo}");

            return sb.ToString();
        }

        /// <summary>
        /// Método que se encarga de:
        /// 
        /// Primero: Verificar que el Turno no sea null.
        /// 
        /// Segundo: Carga el evento con el turno.
        /// 
        /// Tercero: Se ejecuta un bucle while hasta que el estado del Turno no sea "Atendido".
        /// 
        /// Cuarto: Mientras tanto, adentro del bucle va dormir la ejecución del programa (Simulando el paso de estado del turno).
        ///         Cambiará el estado del Turno y volvera a notificar con el evento.
        ///         
        /// Quinto: Si el estado del turno es igual a "Atendido":
        ///         (Verificando que el id este entre un rango y que no puedan darse turnos entre pacientes y especialistas de distintas clínicas).
        /// 
        /// Sexto: Si es de la primer clínica lo inserto en la tabla Turnos de la base de datos.
        ///        Si es de la segunda clínica Lo guardo en un achivo .xml en la ruta especificada en el parcial.
        /// 
        /// </summary>
        public void MockCicloDeVida()
        {
            if (!(this is null))
            {
                this.EventoPasaEstado(this);

                while (this.Estado != EEstado.Atendido)
                {
                    Thread.Sleep(10000);

                    this.Estado++;

                    this.EventoPasaEstado(this);
                }

                if (this.Estado == EEstado.Atendido)
                {

                    if (this.Paciente.Id >= 900 && this.Paciente.Id <= 1899)
                    {
                        if (this.Especialista.Id >= 1500 && this.Especialista.Id <= 1519)
                        {
                            string formatoFechaDelTurno = $"{this.FechaTurno.ToString("yyyy-MM-dd")}";
                            string bitacoraTurno = $"{formatoFechaDelTurno}-{this.Paciente.Apellido}-{this.Paciente.Nombre}";
                            string pathTurnosOtraClinica = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\TurnosClinica" + $@"\{bitacoraTurno}.xml";


                            IArchivo<Turno> turnosPacientesOtraClinica = new XML<Turno>();
                            if (turnosPacientesOtraClinica.Guardar(pathTurnosOtraClinica, this))
                            {
                                /*Guardo en el log.txt los Turnos que se generaron de la segunda clínica.*/

                                GyLString.Guardar($"Se guardó turno de otra clínica en archivo .xml\nRUTA: {pathTurnosOtraClinica}" + GyLString.fechaLog, GyLString.pathLog);
                            }
                        }
                    }
                    else if (!(this.Paciente.Id >= 900 && this.Paciente.Id <= 1899))
                    {
                        if (!(this.Especialista.Id >= 1500 && this.Especialista.Id <= 1519))
                        {
                            TurnoDAO.Insert(this.Paciente.Id, this.Especialista.Id, this.ObservacionesTurno, this.FechaTurno.ToString());
                        }
                    }
                    else
                    {
                        TurnoDAO.Insert(this.Paciente.Id, this.Especialista.Id, this.ObservacionesTurno, this.FechaTurno.ToString());
                    }
                }
            }
        }
        #endregion

        #region Operaciones
        /// <summary>
        /// Sobrecarga del operador ==.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns>True: si son turnos son iguales.</returns>
        public static bool operator ==(Turno t1, Turno t2)
        {
            bool turnosIguales = false;

            if (t1.Paciente.Id == t2.Paciente.Id && t1.Especialista.Id == t2.Especialista.Id)
            {
                turnosIguales = true;
            }

            return turnosIguales;
        }

        /// <summary>
        /// Sobrecarga del operador !=.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns>True: si son turnos son distintos.</returns>
        public static bool operator !=(Turno t1, Turno t2)
        {
            return !(t1 == t2);
        }
        #endregion

    }
}
