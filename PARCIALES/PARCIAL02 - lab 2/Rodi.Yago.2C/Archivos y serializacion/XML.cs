using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos_y_serializacion
{
    public class XML<T> : IArchivo<T>
    {
        #region Implementación de métodos de la interfaces.
        /// <summary>
        /// Implementación del método de la interface IArchivo
        /// que serializa datos en formato XML.
        /// Caso contrario, lanzará la excepción: ArchivosException().
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string pathArchivo, T datos)
        {
            bool pudoSerializar = false;
            XmlTextWriter xmlWriter;
            XmlSerializer xmlSer;

            try
            {
                if (!(pathArchivo is null))
                {
                    if(!(Directory.Exists(pathArchivo)))
                    {
                        if (Path.GetExtension(pathArchivo) is ".xml")
                        {
                            using (xmlWriter = new XmlTextWriter(pathArchivo, Encoding.UTF8))
                            {
                                xmlWriter.Formatting = Formatting.Indented;
                                xmlSer = new XmlSerializer(typeof(T));
                                xmlSer.Serialize(xmlWriter, datos);
                                pudoSerializar = true;
                            }
                        }
                    }
                    
                }
            }
            catch (Exception)
            {
                throw new ArchivosException($"Error al querer Guardar (XML) el archivo: {pathArchivo}.");
            }

            return pudoSerializar;
        }

        /// <summary>
        /// Implementación del método de la interface IArchivo
        /// que deserializa datos en formato XML.
        /// Caso contrario, lanzará la excepción: ArchivosException().
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string pathArchivo, out T datos)
        {
            bool pudoDeserializar = false;
            XmlTextReader xmlReader;
            XmlSerializer xmlSer;
            datos = default;

            try
            {
                if (!(pathArchivo is null))
                {
                    if (Path.GetExtension(pathArchivo) is ".xml")
                    {
                        using (xmlReader = new XmlTextReader(pathArchivo))
                        {
                            xmlSer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSer.Deserialize(xmlReader);
                            pudoDeserializar = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new ArchivosException($"Error al querer Leer (XML) desde el archivo: {pathArchivo}.");
            }

            return pudoDeserializar;
        }
        #endregion

    }
}
