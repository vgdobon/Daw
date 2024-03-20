using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion
{
	public partial class ProbarValidacion2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
			if (Page.IsValid)
			{
				lblResultado.Text = "Las validaciones han resultado correctas";
			}
			else{

				lblResultado.Text = "Las validaciones han resultado incorrectas";
			}
        }

		protected void ListFormat_SelectedIndexChanged(object sender, EventArgs e)
		{
			vsErrores.DisplayMode = (ValidationSummaryDisplayMode)Enum.Parse(typeof(ValidationSummaryDisplayMode), ListFormat.SelectedValue);


		}

		protected void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{
			vsErrores.ShowSummary = lstDisplay.SelectedIndex == 0;
			vsErrores.ShowMessageBox = lstDisplay.SelectedIndex == 1;
		}
	}
}