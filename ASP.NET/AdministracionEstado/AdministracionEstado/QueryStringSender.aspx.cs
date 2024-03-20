using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
    public partial class QueryStringSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) {
                //Elementos de la lista
                lstItems.Items.Add("Sofá económico");
                lstItems.Items.Add("Cortinas de cuero Supreme");
                lstItems.Items.Add("Alfombra de entrada");
                lstItems.Items.Add("Lámpara antigua");
                lstItems.Items.Add("Jacuzzi Retro-Finish");
            }
        }

        protected void cmdGo_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex == -1)
            {
                lblError.Text = "Debes seleccionar un elemento";
            }
            else {
                //Enviar al usuario a la otra página
                //con la cadena de consulta
                string url = "QueryStringRecipient.aspx?";
                url += "Item=" + Server.UrlEncode(lstItems.SelectedItem.Text) +
                    "&Mode="+ chkDetalles.Checked.ToString();
                Response.Redirect(url);
            }
        }
    }
}