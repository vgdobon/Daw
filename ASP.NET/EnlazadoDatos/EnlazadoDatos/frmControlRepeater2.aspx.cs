using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnlazadoDatos
{

	public partial class frmControlRepeater2 : System.Web.UI.Page
	{

		OleDbConnection con { get; set; }
		OleDbDataAdapter adapter { get; set; }

		String[] destinos;
		protected void Page_Load(object sender, EventArgs e)
		{
			destinos = new String[7];

			destinos[0] = "Santander";
			destinos[1] = "Arousa";
			destinos[2] = "Barcelona";
			destinos[3] = "Madrid";
			destinos[4] = "Castellote";
			destinos[5] = "Almería";
			destinos[6] = "Huesca";

			rptDestinos.DataSource = destinos;
			rptDestinos.DataBind();
		}

		protected void Page_Init(object sender, EventArgs e)
		{
		}
	}
}