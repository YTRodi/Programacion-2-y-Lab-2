using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region Métodos
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de Mascota: " + this.GetType());
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Raza: " + this.Raza);
            return sb.ToString();
        }
        #endregion

        #region Constructores
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }
        #endregion


        #region Operadores
        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if (g1.Nombre == g2.Nombre)
            {
                if (g1.Raza == g2.Raza)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //public override bool Equals(Gato obj1, Gato obj2)
        //{
        //    bool retorno = false;

        //    if(obj1 == obj2)
        //    {
        //        retorno = true;
        //    }
        //    return retorno;
        //}
        #endregion
    }
}
