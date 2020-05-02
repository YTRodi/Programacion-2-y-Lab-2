using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Enumerados
        public enum TipoManada
        {
            Única,
            Mixta
        }
        #endregion


        #region Atributos
        private List<Mascota> manada;
        private string nombreGrupo;
        private static TipoManada tipo;
        #endregion

        #region Contructores
        static Grupo()
        {
            tipo = TipoManada.Única;
            //this.tipo = TipoManada.Única;
        }

        private Grupo()
        {
            manada = new List<Mascota>();
        }

        public Grupo(string nombreGrupo) : this()
        {
            this.nombreGrupo = nombreGrupo;
        }

        public Grupo(string nombreGrupo, TipoManada tipo) : this(nombreGrupo)
        {
            //Grupo.tipo = tipo; //porque el atributo tipo es de clase!!!!!!
            this.Tipo = tipo;
        }
        #endregion

        #region Properties
        public TipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
            //NO LO PIDE PERO LO AGREGO
            //get
            //{
            //    return Grupo.tipo;
            //}
        }
        #endregion

        #region Conversiones
        public static implicit operator string(Grupo grupito)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ----------------------------------------");
            sb.AppendFormat("||  Nombre del grupo: {0}  ||\n", grupito.nombreGrupo);
            sb.AppendLine(" ----------------------------------------");
            sb.AppendLine("||            INTEGRANTES:             ||");
            sb.AppendLine(" ----------------------------------------");

            foreach (Mascota integrantes in grupito.manada)
            {
                sb.AppendLine(integrantes.ToString());
                //los if estan de más...
                //if(integrantes is Perro)
                //{
                //    sb.AppendLine(integrantes.ToString());
                //}
                //else if(integrantes is Gato)
                //{
                //    sb.AppendLine(integrantes.ToString());
                //}
            }
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Grupo grupito, Mascota mascotita)
        {
            //FORMA COMO LO PIDE EL PARCIAL!!!!!!!!!!!!!!!!!!!!!!!!!!!
            bool estaEnLaManada = false;

            if (!(grupito is null))
            {
                foreach (Mascota item in grupito.manada)
                {
                    if (item == mascotita)
                    {
                        estaEnLaManada = true;
                    }
                }
            }

            return estaEnLaManada;

            ////Mi forma para validar que sean perros o gatos.
            //bool retorno = false;

            //if(!(grupito is null))
            //{
            //    switch(grupito.Tipo)
            //    {
            //        case TipoManada.Mixta:
            //            retorno = true;
            //            break;

            //        case TipoManada.Única:
            //            if(mascotita is Perro)
            //            {
            //                retorno = true;
            //            }
            //            else if(mascotita is Gato)
            //            {
            //                retorno = true;
            //            }
            //            break;
            //    }
            //}
            //return retorno;
        }

        public static bool operator !=(Grupo grupito, Mascota mascotita)
        {
            return !(grupito == mascotita);
        }


        public static Grupo operator +(Grupo grupito, Mascota mascotita)
        {
            //FORMA COMO LO PIDE EL PARCIAL!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (grupito != mascotita)
            {
                grupito.manada.Add(mascotita);
            }
            return grupito;

            //if(grupito == mascotita)
            //{
            //    if (!(grupito.manada.Contains(mascotita)))
            //    {
            //        grupito.manada.Add(mascotita);
            //    }
            //}

            //return grupito;
        }

        public static Grupo operator -(Grupo grupito, Mascota mascotita)
        {
            //FORMA COMO LO PIDE EL PARCIAL!!!!!!!!!!!!!!!!!!!!!!!!!!!
            for (int i = 0; i < grupito.manada.Count; i++)
            {
                if(grupito.manada[i] == mascotita)
                {
                    grupito.manada.RemoveAt(i);
                }
            }
            return grupito;
        }
        #endregion

    }
}
