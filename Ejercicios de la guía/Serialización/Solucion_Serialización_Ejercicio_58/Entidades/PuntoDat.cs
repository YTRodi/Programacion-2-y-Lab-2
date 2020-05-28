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
        public PuntoDat(string contenido) : this()
        {
            this.contenido = contenido;
        }
        #endregion

        #region Métodos
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            bool guardado = false;
            if (this.ValidarArchivo(ruta, true) && !(objeto is null))
            {
                //objeto = new PuntoDat();//obj a serializar.
                FileStream file = new FileStream(ruta, FileMode.Create);
                BinaryFormatter serializacionBN = new BinaryFormatter();
                serializacionBN.Serialize(file, objeto.Contenido);//.contenido);
                guardado = true;
            }
            return guardado;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            return this.Guardar(ruta, objeto);
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat pD = new PuntoDat();//obj a deserializar.
            Stream file = null;//obj que leera en binario.
            BinaryFormatter serializacionBN = null;//obj que deserializará.

            if (this.ValidarArchivo(ruta, true))
            {
                //pD = new PuntoDat();
                //FileStream file = new FileStream(ruta, FileMode.Open);
                file = new FileStream(ruta, FileMode.Open);
                serializacionBN = new BinaryFormatter();
                pD = (PuntoDat)serializacionBN.Deserialize(file);

                file.Close();
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
                }
                else
                    throw new ArchivoIncorrectoException("El archivo no es un .dat");
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
