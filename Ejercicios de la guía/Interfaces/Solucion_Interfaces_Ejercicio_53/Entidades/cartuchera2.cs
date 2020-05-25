using MétodoEscrituraWrapper;
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cartuchera2
    {
        #region Atributos
        private List<Lapiz> lstLapiz;
        private List<Boligrafo> lstBoligrafo;
        #endregion

        #region Properties
        public List<Lapiz> Lapices
        {
            get
            {
                return this.lstLapiz;
            }
        }
        public List<Boligrafo> Boligrafos
        {
            get
            {
                return this.lstBoligrafo;
            }
        }
        #endregion

        #region Constructores
        public cartuchera2()
        {
            this.lstLapiz = new List<Lapiz>();
            this.lstBoligrafo = new List<Boligrafo>();
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Retornará true si todos los bolígrafos y lapices pudieron gastar exactamente las 1 unidades.
        /// </summary>
        /// <returns></returns>
        public bool ProbarElementos()
        {
            bool gastaronUnaUnidad = false;
            foreach (Lapiz itemLp in this.Lapices)
            {
                if(((IAcciones)itemLp).UnidadesDeEscritura >= 0)
                {
                    ((IAcciones)itemLp).Escribir("L");
                    Console.WriteLine(((IAcciones)itemLp).UnidadesDeEscritura);
                    Console.WriteLine(itemLp);
                }
                else
                {
                    //gastaronUnaUnidad = ((IAcciones)itemLp).Recargar(1);
                    ////NO ESTA IMPLEMENTADO RECARGAR EN LAPIZ
                    ((IAcciones)itemLp).UnidadesDeEscritura += 1;
                    gastaronUnaUnidad = true;
                }
            }

            foreach (Boligrafo itemBl in this.Boligrafos)
            {
                if (((IAcciones)itemBl).UnidadesDeEscritura >= 0)
                {
                    ((IAcciones)itemBl).Escribir("B");
                    Console.WriteLine(((IAcciones)itemBl).UnidadesDeEscritura);
                    Console.WriteLine(itemBl);
                }
                else
                {
                    gastaronUnaUnidad = ((IAcciones)itemBl).Recargar(1);
                }
            }
            
            return gastaronUnaUnidad;
        }
        #endregion

        #region Operaciones
        public static cartuchera2 operator +(cartuchera2 cartu2, object obj)
        {
            if (obj is Lapiz)
                cartu2.lstLapiz.Add((Lapiz)obj);

            else if (obj is Boligrafo)
                cartu2.lstBoligrafo.Add((Boligrafo)obj);

            return cartu2;
        }
        #endregion
    }
}
