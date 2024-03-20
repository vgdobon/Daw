using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
	public partial class QueryStringRecipient : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			lblInfo.Text = "Elemento: " + Request.QueryString["Item"];

			lblInfo.Text += "<br/> Mostrar el registro completo: "
				+ Request.QueryString["Mode"];




		}
	}
}