using EntidadesAbstractas;
using InterfaceXML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases_Instanciables
{
    [XmlInclude(typeof(Aspiradora))]
    [XmlInclude(typeof(Batidora))]
    [XmlInclude(typeof(Cafetera))]
    [XmlInclude(typeof(Depiladora))]
    [XmlInclude(typeof(Licuadora))]
    [XmlInclude(typeof(Plancha))]
    [XmlInclude(typeof(PlanchaPPelo))]
    [XmlInclude(typeof(Ventilador))]
    public class CentralDeVentas
    {
        #region Atributos
        private string razonSocial;
        //string direccion;
        //string CP;
        private List<Electrodomestico> lstElectrodomesticos;
        #endregion

        #region Properties
        public List<Electrodomestico> ListaElectrodomesticos
        {
            get { return this.lstElectrodomesticos; }
            set { this.lstElectrodomesticos = value; }
        }
        public float GananciasTotales
        {
            get { return this.CalcularGanancias(Electrodomestico.ETipo.Todos); }
        }
        public float GananciasMantenimientoCasa
        {
            get { return this.CalcularGanancias(Electrodomestico.ETipo.MantenimientoCasa); }
        }
        public float GananciasAlimentos
        {
            get { return this.CalcularGanancias(Electrodomestico.ETipo.Alimentos); }
        }
        public float GananciasHigiene
        {
            get { return this.CalcularGanancias(Electrodomestico.ETipo.Higiene); }
        }
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }
        #endregion

        #region Constructores
        public CentralDeVentas()
        {
        }
        public CentralDeVentas(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
            this.lstElectrodomesticos = new List<Electrodomestico>();

        }
        #endregion

        #region Métodos
        private bool AgregarElectrodomestico(Electrodomestico nuevoElec)
        {
            bool pudoAgregar = false;
            if (!(this.lstElectrodomesticos is null))
            {
                this.lstElectrodomesticos.Add(nuevoElec);
                pudoAgregar = true;
            }
            return pudoAgregar;
        }
        private float CalcularGanancias(Electrodomestico.ETipo tipoElectrodomestico)
        {
            float valorRecaudado = default(float);

            foreach (Electrodomestico item in this.lstElectrodomesticos)
            {
                switch (tipoElectrodomestico)
                {
                    case Electrodomestico.ETipo.MantenimientoCasa:
                        if (item is Plancha ||
                            item is Aspiradora ||
                            item is Ventilador)
                            valorRecaudado += item.PrecioNeto;
                        break;

                    case Electrodomestico.ETipo.Alimentos:
                        if (item is Licuadora ||
                           item is Cafetera ||
                           item is Batidora)
                            valorRecaudado += item.PrecioNeto;
                        break;

                    case Electrodomestico.ETipo.Higiene:
                        if (item is Depiladora ||
                            item is PlanchaPPelo)
                            valorRecaudado += item.PrecioNeto;
                        break;

                    case Electrodomestico.ETipo.Todos:
                        valorRecaudado += item.PrecioNeto;
                        break;
                }
            }
            return valorRecaudado;
        }

        public static bool Guardar(CentralDeVentas cdv)
        {
            Xml<CentralDeVentas> archivoXmlCdv = new Xml<CentralDeVentas>();
            string ruta = Directory.GetCurrentDirectory() + @"\CentralDeVentas.xml";
            bool pudoGuardar = false;

            if (archivoXmlCdv.Guardar(ruta, cdv))
                pudoGuardar = true;

            return pudoGuardar;
        }
        public static CentralDeVentas Leer()
        {
            Xml<CentralDeVentas> archivoXmlUni = new Xml<CentralDeVentas>();
            string ruta = Directory.GetCurrentDirectory() + @"\CentralDeVentas.xml";

            archivoXmlUni.Leer(ruta, out CentralDeVentas uni);

            return uni;
        }
        #endregion

        #region Operaciones
        public static bool operator ==(CentralDeVentas ctv, Electrodomestico elec)
        {
            bool estaEnLista = false;
            foreach (Electrodomestico item in ctv.lstElectrodomesticos)
            {
                if (item == elec)
                {
                    estaEnLista = true;
                    break;
                }
            }
            return estaEnLista;
        }

        public static bool operator !=(CentralDeVentas ctv, Electrodomestico elec)
        {
            return !(ctv == elec);
        }


        public static CentralDeVentas operator +(CentralDeVentas ctv, Electrodomestico nuevoElec)
        {
            if (ctv != nuevoElec)
                if (ctv.AgregarElectrodomestico(nuevoElec))
                    return ctv;
            //else
            //throw new CentralDeVentasException...
            return ctv;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razón social: {this.razonSocial}");
            sb.AppendLine($"Ganancias totales: ${this.GananciasTotales}");
            sb.AppendLine($"Ganancias sector mantenimiento de la casa : ${this.GananciasMantenimientoCasa}");
            sb.AppendLine($"Ganancias sector alimentos: ${this.GananciasAlimentos}");
            sb.AppendLine($"Ganancias sector higiene: ${this.GananciasHigiene}");

            sb.AppendLine("\nDepósito:\n");
            foreach (Electrodomestico item in this.ListaElectrodomesticos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total de electrodomesticos en el depósito: {this.ListaElectrodomesticos.Count}.");

            return sb.ToString();
        }
        #endregion

    }
}
