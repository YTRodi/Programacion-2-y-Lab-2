using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class UnaExcepcion : Exception
	{
		#region Constructores
		public UnaExcepcion(string mensajeAMandar) : base(mensajeAMandar)
		{
		}
		public UnaExcepcion(string mensajeAMandar, Exception innerException) : base(mensajeAMandar, innerException)
		{
			//INER = DE DONDE VIENE EL ERROR, ES UN PASA MANOS.
		}
		#endregion
	}
}
