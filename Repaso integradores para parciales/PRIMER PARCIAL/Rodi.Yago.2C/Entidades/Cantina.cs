﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> listaBotellas;
        private int espaciosTotales;
        private static Cantina singleton;

        #region Constructores
        private Cantina(int espacios)
        {
            this.listaBotellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        #endregion

        #region Properties
        public List<Botella> Botellas
        {
            get
            {
                return this.listaBotellas;
            }
        }
        #endregion

        #region Métodos
        public static Cantina GetCantina(int espacios)
        {
            if(Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return Cantina.singleton;
        }
        #endregion

        #region Operaciones
        public static bool operator +(Cantina cantinita, Botella botellita)
        {
            bool esta = false;

            if(cantinita.listaBotellas.Count < cantinita.espaciosTotales)
            {
                if(!(cantinita.listaBotellas.Contains(botellita)))
                {
                    esta = true;
                }
                //foreach (Botella item in cantinita.listaBotellas)
                //{
                //    if(item == botellita)
                //    {
                //        esta = true;
                //        //cantinita.listaBotellas.Add(botellita); EL ADD LO HACE LA BARRA.
                //        break;
                //    }
                //}
            }
            return esta;
        }
        #endregion
    }
}
