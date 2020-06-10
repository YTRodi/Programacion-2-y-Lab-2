using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace InterfaceXML
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool pudoSerializar = false;
            XmlTextWriter xmlWriter;
            XmlSerializer xmlSer;

            try
            {
                if (!(archivo is null))
                {
                    if (Path.GetExtension(archivo) is ".xml")
                    {
                        using (xmlWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                        {
                            xmlWriter.Formatting = Formatting.Indented;
                            xmlSer = new XmlSerializer(typeof(T));
                            xmlSer.Serialize(xmlWriter, datos);
                            pudoSerializar = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //throw new ArchivosException(ex);
            }

            return pudoSerializar;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool pudoDeserializar = false;
            XmlTextReader xmlReader;
            XmlSerializer xmlSer;
            datos = default;

            try
            {
                if (!(archivo is null))
                {
                    if (Path.GetExtension(archivo) is ".xml")
                    {
                        using (xmlReader = new XmlTextReader(archivo))
                        {
                            xmlSer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSer.Deserialize(xmlReader);
                            pudoDeserializar = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //throw new ArchivosException(ex);
            }

            return pudoDeserializar;
        }
    }
}
