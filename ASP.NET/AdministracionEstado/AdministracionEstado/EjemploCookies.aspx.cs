using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
	public partial class EjemploCookies : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			HttpCookie cookie = Request.Cookies["Preferences"];
			if (cookie != null)
			{
				lblSaludo.Text = "<b> Cookie encontrada </b> <br/>";
				lblSaludo.Text += "Bienvenido " + cookie["Nombre"] + "<br/>";
			}else{

				lblSaludo.Text = "Cliente desconocido";
			}

		}

        protected void cmdAlmacen_Click(object sender, EventArgs e)
        {
			//Comprobar si la cookie existe y si no crearla
			HttpCookie cookie = Request.Cookies["Preferences"];
			if (cookie == null)
			{
				cookie = new HttpCookie("Preferences");
				cookie["Nombre"] = txtNombre.Text;
				cookie.Expires = DateTime.Now.AddYears(1);
				Response.Cookies.Add(cookie);
				lblSaludo.Text = "Cookie creada <br/>";
				lblSaludo.Text += "Nuevo cliente: " + cookie["Nombre"] + "<br/>";
			}
			else
			{
				lblSaludo.Text = "Cookie ya existe";
			}
			


        }
    }
}