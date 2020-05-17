using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rucula : Ingrediente
	{
		#region Properties
		public override string Proceso
		{
			get
			{
				return "cortar";
			}
		}
		public override string UnidadDeMedida
		{
			get
			{
				return "hojas";
			}
		}
		#endregion

		#region Constructores
		public Rucula(string descripcion, int cantidad) : base(descripcion, cantidad)
		{
		}
		#endregion
	}
}
