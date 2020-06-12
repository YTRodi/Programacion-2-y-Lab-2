using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Temporizador
    {
        #region Atributos

        Thread hilo;
        int intervalo;
        #endregion

        #region Properties

        public bool Activo
        {
            get
            {
                return !(this.hilo is null) && this.hilo.IsAlive;
            }
            set
            {
                if (value)
                {
                    if (this.hilo is null || !(this.hilo.IsAlive))
                    {
                        this.hilo = new Thread(this.Corriendo);
                        this.hilo.Start();
                    }
                }
                else
                {
                    if (!(this.hilo is null) && this.hilo.IsAlive)
                    {
                        this.hilo.Abort();
                    }
                }

                //if (!(this.hilo is null))
                //{
                //    if (value)
                //    {
                //        if (this.Activo)
                //        {
                //            this.hilo = new Thread(this.Corriendo);
                //            this.hilo.Start();
                //        }
                //    }
                //    else
                //    {
                //        if (!this.Activo)
                //        {
                //            this.hilo.Abort();
                //        }
                //    }
                //}
            }
        }
        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        #endregion

        #region Métodos

        private void Corriendo()
        {
            do
            {
                Thread.Sleep(this.intervalo);
                if (!(this.EventoTiempo is null))
                {
                    this.EventoTiempo.Invoke();
                }
            } while (true);

            //while (true)
            //{
            //    Thread.Sleep(this.intervalo);
            //    if (!(this.EventoTiempo is null))
            //    {
            //        this.EventoTiempo.Invoke();
            //    }
            //}
        }

        #endregion

        #region Evento y delegado para el evento

        public delegate void EncargadoTiempo();
        public event EncargadoTiempo EventoTiempo;

        #endregion
    }
}
