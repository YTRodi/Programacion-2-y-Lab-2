using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get 
            {
                if (this.paginas is null)
                {
                    return string.Empty;
                }
                if (i >= 0 && i < this.paginas.Count)
                {
                    return this.paginas[i];
                }
                else
                {
                    return "string vacio (indice fuera de rango)";//string.Empty;//devuelo un string vacio.
                }
            }
            set 
            {
                if(this.paginas is null)//si esta ya existe, la asignará.
                {
                    this.paginas = new List<string>();
                }
                if (i >= 0 && i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else //si el indice es superior el máximo, agrega una nueva página.
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
