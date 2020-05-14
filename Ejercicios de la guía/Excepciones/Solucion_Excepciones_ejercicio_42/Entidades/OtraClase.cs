using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
	{
		#region Métodos
		public void OtroMetodoInstancia()
		{
			try
			{
				new MiClase();
			}
			catch (DivideByZeroException exDiv)
			{
				//Creo una intancia de MiExcepcion para ver sus valores en el debug
				MiExcepcion exPrueba = new MiExcepcion("Excepción desde la clase OtraClase.cs!", exDiv);
				throw exPrueba;
			}
		}
		#endregion
	}
}
