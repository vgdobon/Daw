using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerosControles
{
	public partial class frmBotones : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
			Response.Redirect("https://Marca.com");
        }

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			Response.Redirect("https://www.marvel.com/");
		}
	}
}