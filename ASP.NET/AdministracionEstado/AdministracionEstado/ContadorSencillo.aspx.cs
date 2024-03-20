using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
    public partial class ContadorSencillo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncremento_Click(object sender, EventArgs e)
        {
            int contador;
            if (ViewState["Contador"] == null) { 
                contador = 1;
            }
            else
            {
                contador = (int)ViewState["Contador"] + 1;
            }

            ViewState["Contador"] = contador;
            lblContar.Text = "Contador: " + contador.ToString();
        }
    }
}