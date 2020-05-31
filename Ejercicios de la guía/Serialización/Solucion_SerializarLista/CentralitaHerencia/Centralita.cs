using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<List<Llamada>>
    //where T : Llamada
    {
        public List<Llamada> listaDeLLamadas;
        public string razonSocial;
        private string pathLocal;

        #region Properties
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLLamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLLamada.Provincial);
            }
        }

        public float GananciasPorTodas
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos
        private float CalcularGanancias(Llamada.TipoLLamada tipo)
        {
            float valorRecaudado = default(float);

            //recorro la lista de llamadas
            foreach (Llamada item in this.listaDeLLamadas)
            {
                switch (tipo)//verifico que tipo de llamada es
                {
                    case Llamada.TipoLLamada.Local:

                        if (item is Local)
                        {
                            //valorRecaudado += ((Local)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLLamada.Provincial:
                        if (item is Provincial)
                        {
                            //valorRecaudado += ((Provincial)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;

                        }
                        break;

                    case Llamada.TipoLLamada.Todas:
                        if (item is Local)
                        {
                            //valorRecaudado += ((Local)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;

                        }
                        //else if(item is Provincial)
                        if (item is Provincial)
                        {
                            //valorRecaudado += ((Provincial)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;

                        }
                        break;
                }
            }
            return valorRecaudado;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLLamadas.Add(nuevaLlamada);
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada item in c.listaDeLLamadas)
            {
                if (item == llamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {

            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                if (c.Guardar())
                {

                }
                //else
                //    throw new FallaLogException("No se pudo guardar en el archivo");
            }
            else
            {
                throw new CentralitaException("La llamada ya se encuentra en el sistema", "Centralita", "Operador +/AgregarLlamada");
            }

            return c;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            //return this.Mostrar();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon Social: " + this.razonSocial);
            sb.AppendLine("*******************************");
            sb.AppendLine("Ganacia por Local: " + this.GananciasPorLocal);
            sb.AppendLine("Ganacia por Provincial: " + this.GananciasPorProvincial);
            sb.AppendLine("Ganacia Totales: " + this.GananciasPorTodas);
            sb.AppendLine("*******************************");

            sb.AppendLine("-------Detalle de llamadas realizadas-------");
            foreach (Llamada item in this.listaDeLLamadas)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total de llamadas realizadas: " + this.listaDeLLamadas.Count);

            return sb.ToString();
        }

        #endregion

        #region Interface
        public string RutaDeArchivo
        {
            get { return this.pathLocal; }
            set { this.pathLocal = value; }
        }

        public bool Guardar()
        {
            bool pudoSerializarLista = false;
            XmlTextWriter xmlWriter;
            XmlSerializer xmlSer;
            List<Llamada> oListaLlamadas = new List<Llamada>();

            if (!(this is null) && !(this.RutaDeArchivo is null))
            {
                if (Path.GetExtension(this.RutaDeArchivo) is ".xml")
                {
                    using (xmlWriter = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8))
                    {
                        xmlSer = new XmlSerializer(typeof(List<Llamada>));//(typeof(Llamada));
                        xmlSer.Serialize(xmlWriter, this.listaDeLLamadas); //+ this.razonSocial);
                        pudoSerializarLista = true;
                    }
                }
            }
            else
                throw new InvalidCastException("No es una llamada Local");
            return pudoSerializarLista;
        }

        public List<Llamada> Leer()
        {
            List<Llamada> oListaLlamadas = new List<Llamada>();

            XmlTextReader xmlReader;
            XmlSerializer xmlSer;
            using (xmlReader = new XmlTextReader(this.RutaDeArchivo))
            {
                xmlSer = new XmlSerializer(typeof(List<Llamada>));
                oListaLlamadas = (List<Llamada>)xmlSer.Deserialize(xmlReader);
            }
            return oListaLlamadas;
        }
        #endregion
    }
}
