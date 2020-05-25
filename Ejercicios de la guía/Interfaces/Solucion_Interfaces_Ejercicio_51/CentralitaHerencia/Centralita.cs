using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace CentralitaHerencia
{
    public class Centralita<T> : IGuardar<T>
        where T : Llamada
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;

        #region Properties
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLLamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLLamada.Provincial);
            }
        }

        public float GananciasPorTodas
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos
        private float CalcularGanancias(Llamada.TipoLLamada tipo)
        {
            float valorRecaudado = default(float);

            //recorro la lista de llamadas
            foreach (Llamada item in this.listaDeLLamadas)
            {
                switch (tipo)//verifico que tipo de llamada es
                {
                    case Llamada.TipoLLamada.Local:

                        if (item is Local)
                        {
                            //valorRecaudado += ((Local)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLLamada.Provincial:
                        if (item is Provincial)
                        {
                            //valorRecaudado += ((Provincial)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;

                        }
                        break;

                    case Llamada.TipoLLamada.Todas:
                        if (item is Local)
                        {
                            //valorRecaudado += ((Local)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;

                        }
                        //else if(item is Provincial)
                        if (item is Provincial)
                        {
                            //valorRecaudado += ((Provincial)item).CostoLlamada;
                            valorRecaudado += item.CostoLlamada;

                        }
                        break;
                }
            }
            return valorRecaudado;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLLamadas.Add(nuevaLlamada);
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Centralita<T> c, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada item in c.listaDeLLamadas)
            {
                if (item == llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita<T> c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita<T> operator +(Centralita<T> c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                //throw new CentralitaException()//SI NO ESTA LA LLAMADA,
                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("La llamada ya se encuentra en el sistema", "Centralita", "Operador +/AgregarLlamada");
            }

            return c;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            //return this.Mostrar();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon Social: " + this.razonSocial);
            sb.AppendLine("*******************************");
            sb.AppendLine("Ganacia por Local: " + this.GananciasPorLocal);
            sb.AppendLine("Ganacia por Provincial: " + this.GananciasPorProvincial);
            sb.AppendLine("Ganacia Totales: " + this.GananciasPorTodas);
            sb.AppendLine("*******************************");

            sb.AppendLine("-------Detalle de llamadas realizadas-------");
            foreach (Llamada item in this.listaDeLLamadas)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total de llamadas realizadas: " + this.listaDeLLamadas.Count);

            return sb.ToString();
        }

        #endregion

        #region Interface
        public string RutaDeArchivo
        {
            get
            {
                return "Ruta del archivo";
            }
            set
            {
                //idk
            }
        }

        public bool Guardar()
        {
            return true;
        }

        public T Leer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
