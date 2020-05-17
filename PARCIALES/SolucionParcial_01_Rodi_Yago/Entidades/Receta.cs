using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Receta
	{
		#region Enumerado
		public enum Tipo
		{
			Clasica,
			Especial
		}
		#endregion

		#region Atributos
		private int capacidadDelContenedor;
		private List<Ingrediente> ingredientes;
		private static Tipo preparacion;
		#endregion

		#region Properties
		public static Tipo TipoDePreparacion
		{
			set
			{
				Receta.preparacion = value;
			}
		}
		#endregion

		#region Constructores
		static Receta()
		{
			Receta.preparacion = Tipo.Clasica;
		}
		private Receta()
		{
			this.ingredientes = new List<Ingrediente>();
		}
		public Receta(int capacidad) : this()
		{
			this.capacidadDelContenedor = capacidad;
		}
		#endregion

		#region Métodos
		private int capacidadLibre()
		{
			int suma = 0;
			foreach (Ingrediente item in this.ingredientes)
			{
				//acumulo.
				suma += item.Cantidad; 
			}
			return suma;
		}
		private int capacidadLibre(Ingrediente planta)
		{
			int totalLibre = this.capacidadLibre() + planta.Cantidad;
			return totalLibre;
		}

		public static bool operator +(Receta receta, Ingrediente ingrediente)
		{
			bool agrego = false;
			int capacidadLibreDelMétodo = receta.capacidadLibre(ingrediente);

			if (receta.capacidadDelContenedor >= capacidadLibreDelMétodo)
			{
				receta.ingredientes.Add(ingrediente);
				agrego = true;
			}
			return agrego;
		}

		#endregion

		#region Override
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(string.Format("Receta: {0}" , Receta.preparacion));
			sb.AppendLine(string.Format("Capacidad libre: {0}" ,this.capacidadLibre()));
			sb.AppendLine(string.Format("Capacidad total: {0}" ,this.capacidadDelContenedor));

			foreach (Ingrediente item in this.ingredientes)
			{
				sb.AppendLine(string.Format("Lista de ingredientes: {0}", item.Informacion()));
			}

			return sb.ToString();
		}
		#endregion

	}
}
