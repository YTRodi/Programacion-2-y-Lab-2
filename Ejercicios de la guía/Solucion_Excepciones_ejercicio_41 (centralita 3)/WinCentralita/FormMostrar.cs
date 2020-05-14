using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCentralita
{
    public partial class FormMostrar : Form
    {
        Centralita centralitaMostrar;
        private Llamada.TipoLLamada tipoLlamada;

        #region Constructores
        public FormMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralitaMostrar = centralita;
        }
        #endregion


        #region Properties
        public Llamada.TipoLLamada TipoLlamada
        {
            set//para que necesito un set?
            {
                this.tipoLlamada = value;
            }
            get
            {
                return this.tipoLlamada;
            }
        }

        #endregion

        #region Load
        private void FormMostrar_Load(object sender, EventArgs e)
        {
            switch(this.TipoLlamada)
            {
                case Llamada.TipoLLamada.Todas:
                    richTxtBoxMostrar.Text = centralitaMostrar.ToString();
                    break;

                case Llamada.TipoLLamada.Local:
                    richTxtBoxMostrar.Text = MostrarLocal(centralitaMostrar);
                    break;

                case Llamada.TipoLLamada.Provincial:
                    richTxtBoxMostrar.Text = MostrarProvincial(centralitaMostrar);
                    break;
            }
        }
        #endregion

        #region Métodos para mostrar
        public string MostrarLocal(Centralita auxCentralita)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******************************\n");
            sb.AppendLine("Ganacias por llamadas locales: " + (auxCentralita.GananciasPorLocal).ToString());
            sb.AppendLine("\n*******************************");
            foreach (Llamada item in auxCentralita.Llamadas)
            {
                if(item is Local)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public string MostrarProvincial(Centralita auxCentralita)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******************************\n");
            sb.AppendLine("Ganacias por llamadas provinciales: " + (auxCentralita.GananciasPorProvincial).ToString());
            sb.AppendLine("\n*******************************");
            foreach (Llamada item in auxCentralita.Llamadas)
            {
                if (item is Provincial)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
        #endregion

    }
}
