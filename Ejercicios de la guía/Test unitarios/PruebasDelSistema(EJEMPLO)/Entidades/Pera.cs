using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pera : Ingrediente
	{
		#region Atributos
		private string tipo;
		#endregion

		#region Properties
		public override string Proceso
		{
			get
			{
				return "cubitar";
			}
		}
		public override string UnidadDeMedida
		{
			get
			{
				return "unidades";
			}
		}
		#endregion

		#region Constructores
		public Pera(string descripcion, int cantidad, string tipo) : base(descripcion, cantidad)
		{
			this.tipo = tipo;
		}
		#endregion

		#region Métodos
		public override string Informacion()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(string.Format("{0}", base.Informacion()));
			sb.AppendLine(string.Format("Tipo: {0}", this.tipo));
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
