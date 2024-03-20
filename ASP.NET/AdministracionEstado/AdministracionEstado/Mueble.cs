using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministracionEstado
{
	public class Mueble
	{
		public string Nombre { get; set; }

		private string descripcion;
		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		public decimal Precio { get; set; }

		public Mueble(string nombre, string descripcion, decimal precio)
		{
			this.Nombre = nombre;
			this.Descripcion = descripcion;
			this.Precio = precio;
		}
	}
}