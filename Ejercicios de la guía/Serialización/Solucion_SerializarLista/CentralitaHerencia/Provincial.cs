﻿using Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        private string pathLocal;
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        #region Properties
        public override float CostoLlamada//si no lo pongo esto, sale error, porque la propiedad CostoLlamada de la clase Llamada es abstract.
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial()
        {

        }
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string pOrigen, Franja miFranja, float pDuracion, string pDestino)
            : base(pDuracion, pDestino, pOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retornará el valor de la llamada a partir de la duración y el costo de la misma.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costoCalculado = default(float);

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoCalculado = base.Duracion * 0.99f;
                    break;

                case Franja.Franja_2:
                    costoCalculado = base.Duracion * 1.25f;
                    break;

                case Franja.Franja_3:
                    costoCalculado = base.Duracion * 0.66f;
                    break;
            }
            return costoCalculado;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            //sb.AppendLine("-------Datos desde Provincial-------");
            sb.AppendLine("Tipo de llamada: " + this.GetType());
            sb.AppendLine("Franja horaria: " + this.franjaHoraria);
            sb.AppendLine("Costo llamada: $" + this.CostoLlamada);

            return sb.ToString();
        }
        #endregion

        #region Intereface
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

            if (!(this is null) && this is Provincial && !(this.RutaDeArchivo is null))
            {
                if (Path.GetExtension(this.RutaDeArchivo) is ".xml")
                {
                    using (xmlWriter = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8))
                    {
                        xmlSer = new XmlSerializer(typeof(Provincial));
                        xmlSer.Serialize(xmlWriter, this);
                        pudoSerializar = true;
                    }
                }
                 
            }
            else
                throw new InvalidCastException("No es una llamada Local");
            return pudoSerializar;
        }

        public Provincial Leer()
        {
            Provincial oProvincialRetorno = new Provincial();
            XmlTextReader xmlReader;
            XmlSerializer xmlSer;

            if (!(this is null) && this is Provincial && !(this.RutaDeArchivo is null))
            {
                if (Path.GetExtension(this.RutaDeArchivo) is ".xml")
                {
                    using (xmlReader = new XmlTextReader(this.RutaDeArchivo))
                    {
                        xmlSer = new XmlSerializer(typeof(Provincial));
                        oProvincialRetorno = (Provincial)xmlSer.Deserialize(xmlReader);
                    }
                }
            }
            else
                throw new InvalidCastException("No es una llamada Local");
            return oProvincialRetorno;
        }
        #endregion
    }
}
