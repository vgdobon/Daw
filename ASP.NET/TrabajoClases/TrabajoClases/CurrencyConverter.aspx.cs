using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoClases
{
	public partial class CurrencyConverter : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Currency.Items.Add(new ListItem( "USD", "0.9"));
				Currency.Items.Add(new ListItem("Yen Japonés", "110.33"));
				Currency.Items.Add(new ListItem("Dólar Canadiense", "1.2"));
			}
		}

		protected void btnConvertir_ServerClick(object sender, EventArgs e)
		{
			decimal USAmount = Decimal.TryParse(US.Value, out decimal result) ? result : 0;

			if (USAmount > 0)
			{
				//Recuperar la moneda seleccionada por su indice
				ListItem monedaSeleccionada = Currency.Items[Currency.SelectedIndex];

				decimal monedaSeleccionadaAmount = Decimal.Parse(monedaSeleccionada.Value)
					* USAmount;

				Response.Write("<h1>" + USAmount + " USD = " + monedaSeleccionadaAmount + " "
					+ monedaSeleccionada.Text+ "</h1>");
			}
			else{
				Response.Write("<h1>Ingrese un valor valido</h1>");
			}
		}
	}
}