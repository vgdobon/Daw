using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingPrueba
{
	public partial class frmDiccionario : System.Web.UI.Page
	{


		protected void Page_Load(object sender, EventArgs e)
		{

			if (!Page.IsPostBack)
			{
				Dictionary<int, string> frutas = new Dictionary<int, string>();

				frutas.Add(1, "Piña");
				frutas.Add(2, "Sandía");
				frutas.Add(3, "Naranja");
				frutas.Add(4, "Melón");
				frutas.Add(5, "Kiwi");
				frutas.Add(6, "Fresa");
				frutas.Add(7, "Mango");
				frutas.Add(8, "Maracuyá");
				frutas.Add(9, "Uva");


				//Definir el enlace

				lstFrutas.DataSource = frutas;
				lstFrutas.DataTextField = "Value";
				lstFrutas.DataValueField = "Key";

				lstFrutas.DataBind();
			}



		}

		protected void lstFrutas_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblSalida.Text = "Has seleccionado: " + lstFrutas.SelectedItem.Text +
				"<br/> Y su clave es: " + lstFrutas.SelectedItem.Value;

		}

		
	}
}