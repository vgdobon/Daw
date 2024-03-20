using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesRicos
{
	public partial class frmEventos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Log("Page Load()");
		}

		protected void Pre_Render(object sender, EventArgs e)
		{
			Log("Page Pre_Render()");
		}

		protected void txtEvento_TextChanged(object sender, EventArgs e)
		{

		}
		protected void ControlChanged(object sender, EventArgs e)
		{

			//Encontrar el control que generó el evento
			string crlName = ((Control)sender).ID;
			//Mostrar el nombre del control
			Log(crlName + "Ha cambiada");



		}

		private void Log(string mensaje)
		{
			lstEventos.Items.Add(mensaje);
			lstEventos.SelectedIndex = lstEventos.Items.Count - 1;
		}

	}
}