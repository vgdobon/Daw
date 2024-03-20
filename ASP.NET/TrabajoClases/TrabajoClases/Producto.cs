using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoClases
{
	//Definir un delegado que represente el evento
	public delegate void PriceChangedEventHandler();
	public class Producto
	{

		//Definir el evento usando el delegado
		public event PriceChangedEventHandler PriceChanged;

		
		public String Id { get; set; }
		
		public string Nombre { get; set; }

		public string Descripcion { get; set; }


		private double precio;
		public double Precio
		{
			get { return precio; }
			set
			{
				precio = value;
				if (PriceChanged != null)
				{
					PriceChanged();
				}
			}
		}
		private string urlImage;



		public string UrlImagen
		{
			get { return urlImage; }
			set { urlImage = value; }
		}


		public Producto()
		{
		}

		public Producto(String id, string nombre, string descripcion, double precio)
		{
			Id = id;
			Nombre = nombre;
			Descripcion = descripcion;
			Precio = precio;
		}

		public Producto(String id, string nombre, double precio)
		{
			this.Id = id;
			this.Nombre = nombre;
			this.Precio = precio;
		}

		public override string ToString()
		{
			return "Id: " + this.Id + " Nombre: " + this.Nombre + " Descripcion: " + this.Descripcion + " Precio: " + this.Precio;
		}

		public string GetHtml()
		{
			string html = "<div class='producto'>";
			html += "<img src='" + this.UrlImagen + "' alt='" + this.Nombre + "' />";
			html += "<h2>" + this.Nombre + "</h2>";
			html += "<p>" + this.Descripcion + "</p>";
			html += "<p>" + this.Precio + "</p>";
			html += "</div>";
			return html;
		}

		

	}
}