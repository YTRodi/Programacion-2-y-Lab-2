using Archivos_y_serializacion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_y_serializacion
{
    public class PuntoDat<T> : IArchivo<T>
    {
        #region Implementación de métodos de la interfaces.

        /// <summary>
        /// Implementación del método de la interface IArchivo
        /// que serializa datos en formato binario.
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string pathArchivo, T datos)
        {
            FileStream fs;
            BinaryFormatter serBN;
            bool pudoSerializar = false;

            if (!(pathArchivo is null))
            {
                fs = new FileStream(pathArchivo, FileMode.OpenOrCreate);//OrCreate, FileAccess.Write, FileShare.None);
                serBN = new BinaryFormatter();
                serBN.Serialize(fs, datos);
                fs.Close();
                pudoSerializar = true;
            }

            return pudoSerializar;
        }

        /// <summary>
        /// Implementación del método de la interface IArchivo
        /// que deserializa datos en formato binario.
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string pathArchivo, out T datos)
        {
            FileStream fs;//obj que leera en binario.
            BinaryFormatter deserBN;//obj que deserializará.
            bool pudoLeer = false;
            datos = default;

            if(!(pathArchivo is null))
            {
                fs = new FileStream(pathArchivo, FileMode.Open);//, FileAccess.Read, FileShare.ReadWrite);
                deserBN = new BinaryFormatter();
                datos = (T)deserBN.Deserialize(fs);
                fs.Close();
                pudoLeer = true;
            }

            return pudoLeer;
        }
        #endregion
    }
}
