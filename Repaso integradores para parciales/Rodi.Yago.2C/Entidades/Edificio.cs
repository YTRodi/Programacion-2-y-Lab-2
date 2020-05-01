using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        /* TODOS: a la pregunta de Iván y Yanina agreguen la propiedad para hacer pública la Cantina en Barra*/

        #region Atributos
        private Cantina[] cantinas;
        private const short LIMITE_CANTINAS = 2;
        private static Edificio singleton;
        #endregion

        #region Constructores
        private Edificio()
        {
            this.cantinas = new Cantina[LIMITE_CANTINAS];
        }

        static Edificio()
        {
            Edificio.singleton = new Edificio();
        }
        #endregion

        #region Métodos
        public static Edificio GetBar()
        {
            return Edificio.singleton;
        }
        #endregion

        #region Operadores
        public static bool operator +(Edificio edif, Cantina canti)
        {
            bool retorno = false;

            if(!(Edificio.singleton is null))
            {
                if (!(edif is null) && !(canti is null))
                {
                    for (int i = 0; i < edif.cantinas.Length; i++)
                    {
                        if (edif.cantinas[i] is null)
                        {
                            edif.cantinas[i] = canti;
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            



            //NO SE USAR EL == DE BOTELLA
            //if (!edif.cantinas.Contains(canti))
            //{
            //    retorno = true;
            //}
            //else
            //{
            //    retorno = false;
            //}



            //for (int i = 0; i < edif.cantinas.Length; i++) 
            //{
            //    //if(!(edif.cantinas is null))
            //    //if(!(edif.cantinas is null))
            //    //{
            //    //    retorno = true;
            //    //}
            //    //if(edif.cantinas.Length < canti.Botellas.Count)
            //    if(!(edif.cantinas is null)) //esta vacio
            //    {
            //        if (edif.cantinas[i] == canti)
            //        {
            //            edif.cantinas[i] = canti;//cargo la cantina en este lugar.
            //            retorno = true;
            //        }
            //    }
            //    else
            //    {
            //        retorno = false;
            //    }
            //}


            //if (!(edif is null) && !(canti is null))
            //{
            //    for (int i = 0; i < edif.cantinas.Length; i++)
            //    {
            //        if (edif.cantinas[i] == null)
            //        {
            //            edif.cantinas[i] = canti;
            //            retorno = true;
            //            break;
            //        }
            //    }
            //}

            return retorno;

        }
        #endregion

    }
}
