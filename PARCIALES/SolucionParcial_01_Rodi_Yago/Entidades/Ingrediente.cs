using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Ingrediente
	{
		#region Atributos
		private int cantidad;
		private string descripcion;
		#endregion

		#region Properties

		public int Cantidad
		{
			get
			{
				return this.cantidad;
			}
		}
		public abstract string Proceso { get;}
		public abstract string UnidadDeMedida { get;}
		#endregion

		#region Constructores
		public Ingrediente(string descripcion, int cantidad)
		{
			this.descripcion = descripcion;
			this.cantidad = cantidad;
		}
		#endregion

		#region Métodos
		public virtual string Informacion()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(string.Format("{0} en una cantidad de {1} {2}\n", this.descripcion, this.Cantidad, this.UnidadDeMedida));
			sb.AppendLine(string.Format("Procesar {0}",this.Proceso));
			return sb.ToString();
		}
		#endregion

		#region Conversiones

		#endregion

		#region Operaciones

		#endregion

		#region Override

		#endregion


	}
}
