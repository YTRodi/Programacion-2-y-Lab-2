using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
	{
		#region Constructores
		//2do
		public MiClase()
		{
			try
			{
				MiClase.MetodoEstatico();
				//relanzo el método hacia un constructor de instancia
			}
			catch (DivideByZeroException exDiv)
			{
				throw exDiv;
			}
		}

		//3ro
		public MiClase(string paraNoSerIgual)
		{
			try
			{
				new MiClase();//instancio.
			}
			catch (DivideByZeroException exDiv)
			{
				throw new UnaExcepcion("No se puede dividir por 0", exDiv);
			}
		}
		#endregion

		#region Métodos
		//1ro
		public static void MetodoEstatico()
		{
			try
			{
				int num01 = 20;
				int num02 = 0;
				int resultado = num01 / num02; //provoco la excepción.
			}
			catch (DivideByZeroException exDiv)//Siempre capturo la misma excepción.
			{
                throw exDiv;
			}
		}
		#endregion
	}
}
