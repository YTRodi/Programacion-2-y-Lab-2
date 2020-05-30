using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Interfaces;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        public float costo;
        private string pathLocal;

        #region Properties
        public override float CostoLlamada
        {
            get
            {
                //return this.CalcularCosto();
                return base.duracion * this.costo;//XMLSERIALIZER NO SERIALIZA MÉTODOS
            }
        }

        #endregion

        #region Constructores
        public Local()
        {

        }
        public Local(Llamada pLlamada, float pCosto)
            : this(pLlamada.NroOrigen, pLlamada.Duracion, pLlamada.NroDestino, pCosto)
        {

        }

        public Local(string pOrigen, float pDuracion, string pDestino, float pCosto)
            : base(pDuracion, pDestino, pOrigen)
        {
            this.costo = pCosto;
        }

        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Tipo de llamada: " + this.GetType());
            sb.AppendLine("Costo de la llamada: $" + this.CostoLlamada);

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
            bool pudoSerializar = false;
            XmlTextWriter xmlWriter;
            XmlSerializer xmlSer;

            if (!(this is null) && this is Local && !(this.RutaDeArchivo is null))
            {
                if (Path.GetExtension(this.RutaDeArchivo) is ".xml")
                {
                    using (xmlWriter = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8))
                    {
                        xmlSer = new XmlSerializer(typeof(Local));
                        xmlSer.Serialize(xmlWriter, this);
                        pudoSerializar = true;
                    }
                }
            }
            else
                throw new InvalidCastException("No es una llamada Local");
            return pudoSerializar;
        }

        public Local Leer()
        {
            Local oLocalRetorno = new Local();
            XmlTextReader xmlReader;
            XmlSerializer xmlSer;

            if (!(this is null) && this is Local && !(this.RutaDeArchivo is null))
            {
                if (Path.GetExtension(this.RutaDeArchivo) is ".xml")
                {
                    using (xmlReader = new XmlTextReader(this.RutaDeArchivo))
                    {
                        xmlSer = new XmlSerializer(typeof(Local));
                        oLocalRetorno = (Local)xmlSer.Deserialize(xmlReader);
                    }
                }
            }
            else
                throw new InvalidCastException("No es una llamada Local");
            return oLocalRetorno;
        }
        #endregion
    }
}
