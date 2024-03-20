using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
	public partial class EstadoAplicacion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int contadorSencillo = 0;
			int contadorAplicacion = 0;
			if (Application["contadorAplicacion"] != null)
			{
				contadorSencillo = (int)Application["contadorAplicacion"];
			}else{
					Application["contadorAplicacion"] = 0;
			}
			contadorAplicacion++;

			Application["contadorAplicacion"] = contadorAplicacion;



		}
	}
}