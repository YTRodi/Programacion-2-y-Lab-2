using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CompetenciaNoDisponibleException : Exception
	{
		#region Atributos
		private string nombreClase;
		private string nombreMetodo;
		#endregion

		#region Properties
		public string NombreClase { get { return this.nombreClase; } }
		public string NombreMetodo { get { return this.nombreMetodo; } }
		#endregion

		#region Constructores
		public CompetenciaNoDisponibleException(string msg, string clase, string metodo)
			: this(msg, clase, metodo, null)
		{
			//Como no hay referencia a un InnerException, por defecto es null.
		}
		public CompetenciaNoDisponibleException(string msg, string clase, string metodo, Exception innerException)
			: base(msg, innerException)
		{
			this.nombreClase = clase;
			this.nombreMetodo = metodo;
		}
		#endregion

		#region Override
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat($"\tExcepción del método: {this.NombreMetodo} || de la clase: {this.NombreClase}\n");
			sb.AppendFormat($"\t{this.Message}");//msg propio de la excepción.
			return sb.ToString();
		}
		#endregion


	}
}
