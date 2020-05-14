﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CentralitaException : Exception
	{
		#region Atributos
		private string nombreClase;
		private string nombreMetodo;
		#endregion

		#region Properties

		public string NombreClase
		{
			get
			{
				return this.nombreClase;
			}
		}
		public string NombreMetodo
		{
			get
			{
				return this.nombreMetodo;
			}
		}
		#endregion

		#region Constructores
		public CentralitaException(string mensaje, string clase, string metodo)
			: this(mensaje, clase, metodo, null)//si no hay ref, va null
		{
			//InnerException = la envuelvo con una excepcion nueva.
		}
		public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
			: base(mensaje, innerException)
		{
			this.nombreClase = clase;
			this.nombreMetodo = metodo;
		}
		#endregion

		#region Métodos

		#endregion

		#region Conversiones

		#endregion

		#region Operaciones

		#endregion

		#region Override

		#endregion

	}
}
