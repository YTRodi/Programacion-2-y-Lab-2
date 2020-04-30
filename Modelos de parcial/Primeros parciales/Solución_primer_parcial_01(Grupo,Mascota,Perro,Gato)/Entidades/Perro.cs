using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Constructores
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Métodos
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de Mascota: " + this.GetType());
            if(this.esAlfa == true)
            {
                sb.AppendLine("Nombre: " + this.Nombre);
                sb.AppendLine("Raza: " + this.Raza);
                sb.AppendLine("Alfa de la manada : SI");
                sb.AppendLine("Edad: " + this.edad);
            }
            else
            {
                sb.AppendLine("Nombre: " + this.Nombre);
                sb.AppendLine("Raza: " + this.Raza);
                sb.AppendLine("Edad: " + this.edad);
            }
            return sb.ToString();
        }

        #endregion

        #region Operadores
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            //No puedo usar equals porque sino evaluaria si esAlfa tambien... y no lo pide.

            if (p1.Nombre == p2.Nombre)
            {
                if (p1.Raza == p2.Raza)
                {
                    if (p1.edad == p2.edad)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro perrito)
        {
            return perrito.edad;
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
            //tiene que usar el ==
        }
        #endregion


    }
}
