using MétodoEscrituraWrapper;
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        #region Atributos
        private List<IAcciones> listaUtiles;
        #endregion

        #region Properties
        public List<IAcciones> Utiles
        {
            get
            {
                return this.listaUtiles;
            }
        }
        #endregion

        #region Constructores
        public Cartuchera1()
        {
            this.listaUtiles = new List<IAcciones>();
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Retornará true si todos los bolígrafos pudieron gastar exactamente las 1 unidades.
        /// </summary>
        /// <returns></returns>
        public bool ProbarElementos()
        {
            bool gastaronUnaUnidad = false;

            foreach (IAcciones elementos in this.listaUtiles)
            {
                if (elementos is Lapiz)
                {
                    if (elementos.UnidadesDeEscritura >= 0)
                    {
                        elementos.Escribir("L");
                        Console.WriteLine(elementos);
                    }
                }

                if (elementos is Boligrafo)
                {
                    if (elementos.UnidadesDeEscritura >= 0)
                    {
                        elementos.Escribir("B");
                        Console.WriteLine(elementos);
                    }
                    else
                    {
                        gastaronUnaUnidad = elementos.Recargar(1);
                        //elementos.Recargar(1);
                        //gastaronUnaUnidad = true;
                    }
                }
            }
            return gastaronUnaUnidad;
        }
        #endregion

        #region Operaciones
        public static Cartuchera1 operator +(Cartuchera1 cartu1, object obj)
        {
            if (obj is Lapiz || obj is Boligrafo)
                cartu1.listaUtiles.Add((IAcciones)obj);

            return cartu1;
        }
        #endregion
    }
}
