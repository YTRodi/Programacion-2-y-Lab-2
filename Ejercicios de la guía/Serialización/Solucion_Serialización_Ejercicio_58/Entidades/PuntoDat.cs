using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivo<PuntoDat>
    {
        #region Atributos
        //con el "@" no te corta la clausula de escape "\".
        private string contenido;
        #endregion

        #region Properties
        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }
        #endregion

        #region Constructores
        public PuntoDat()
        {
        }
        public PuntoDat(string contenido)// : this()
        {
            this.contenido = contenido;
        }
        #endregion

        #region Métodos
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            FileStream fs = null;
            BinaryFormatter serBN = null;
            bool pudoSerializar = false;

            if (this.ValidarArchivo(ruta, true))// && !(objeto is null))
            {
                fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                serBN = new BinaryFormatter();
                serBN.Serialize(fs, objeto);
                fs.Close();
                pudoSerializar = true;
            }
            return pudoSerializar;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            return this.Guardar(ruta, objeto);
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat pD = null;//obj a deserializar.
            FileStream fs;//obj que leera en binario.
            BinaryFormatter deserBN;//obj que deserializará.

            if (this.ValidarArchivo(ruta, true))// && !(pD is null))
            {
                pD = new PuntoDat();
                fs = new FileStream(ruta, FileMode.Open);//, FileAccess.Read, FileShare.ReadWrite);
                deserBN = new BinaryFormatter();
                pD = (PuntoDat)deserBN.Deserialize(fs);
                fs.Close();
            }
            return pD;
        }
        #endregion

        #region Override
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool extensionCorrecta = false;

            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) is ".dat")
                        extensionCorrecta = true;
                    else
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                }
            }
            catch (FileNotFoundException fNotFound)
            {
                throw new FileNotFoundException("El archivo no existe", fNotFound);
            }
            catch (ArchivoIncorrectoException aE)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", aE);
            }

            return extensionCorrecta;
        }
        #endregion
    }
}
