using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnConsola
{
    [Serializable]
    public class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Constructores
        public Persona()
        {
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Serializa una Persona en binario.
        /// </summary>
        /// <param name="personita">Persona a serializar</param>
        /// <returns></returns>
        public static bool Guardar(Persona personita)
        {
            Stream fs = null;
            BinaryFormatter serBN = null;
            string nombreArchivo = "pruebaBinario.dat";

            bool pudoSerializar = false;
            //personita = new Persona(personita.nombre, personita.apellido);

            if (!(personita is null))
            {
                fs = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
                //si no pongo el path completo, se guarda en la misma carpeta donde está el ejecutable.
                serBN = new BinaryFormatter();
                serBN.Serialize(fs, personita);
                fs.Close();
                pudoSerializar = true;
            }
            return pudoSerializar;
        }
        /// <summary>
        /// Deserializa una persona
        /// </summary>
        /// <returns></returns>
        public static Persona Leer()
        {
            Persona pAux = new Persona();
            Stream fs = null;
            BinaryFormatter serBN = null;
            string path = "pruebaBinario.dat";

            if (!(pAux is null))
            {
                fs = new FileStream(path, FileMode.Open);
                serBN = new BinaryFormatter();
                pAux = (Persona)serBN.Deserialize(fs);
                fs.Close();
            }
            return pAux;
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            return sb.ToString();
        }

    }
}
