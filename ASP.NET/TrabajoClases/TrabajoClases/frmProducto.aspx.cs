using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using TrabajoClases.Properties;

namespace TrabajoClases
{
	public partial class frmProducto : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnProducto_Click(object sender, EventArgs e)
        {
			Producto p1 = new Producto("AAA-111", "Cafetera Italiana", "Cafetera Italiana de 6 tazas", 24.89);
			p1.UrlImagen = "cafetera.jpg";


			lblNuevoProducto.Text += p1.GetHtml();

			//Producto p1 = new Producto();
			//p1.Id = "AAA-111";
			//p1.Nombre = "Cafetera Italiana";
			//p1.Descripcion = "Cafetera Italiana de 6 tazas";
			//p1.Precio = 24.89;
			//lblProducto.Text = p1;

			//Esto conecta el evento p1.PriceChanged con el
			// manejador de eventos ChangeDetected
			//ChangeDetected tiene que tener la misma firma que el delegado PriceChangedEventHandler


			p1.PriceChanged += ChangeDetected;
			p1.Precio = 25.00;
			
		}

		protected void btnCrearProducto_Click(object sender, EventArgs e)
		{
			Producto p1 = new Producto(txtID.Text, txtNombre.Text, Convert.ToDouble(txtPrecio.Text));

			lblNuevoProducto.Text = p1.ToString();

		}

		public void ChangeDetected()
		{
			//Este código se ejecutará cuando se dispare el evento PrinceChanged
			lblNuevoProducto.Text += "El precio ha cambiado";
		}
	}
}