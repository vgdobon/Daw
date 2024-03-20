using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoClases
{
	public partial class PaginaHtmlServidor : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnMostrar_ServerClick(object sender, EventArgs e)
		{
			txtSalida.Value = txtFrase.Value;
		}
	}
}