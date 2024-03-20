using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class frmCheckBoxList2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				CargarLenguajes();
			}
			
		}

		public void CargarLenguajes()
		{
			cblLenguajes.Items.Add(new ListItem("C#", "1"));
			cblLenguajes.Items.Add(new ListItem("VB.NET", "2"));
			cblLenguajes.Items.Add(new ListItem("Java", "3"));
			cblLenguajes.Items.Add(new ListItem("Python", "4"));
			cblLenguajes.Items.Add(new ListItem("Ruby", "5"));
			cblLenguajes.Items.Add(new ListItem("C++", "6"));
			cblLenguajes.Items.Add(new ListItem("C", "7"));
			cblLenguajes.Items.Add(new ListItem("Swift", "8"));
		}

		protected void BtnMostrar_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder("Has seleccionado: <br/></br>");
			LenguajesSeleccionados(sb);

			lblSalida.Text = sb.ToString();
		}

		private void LenguajesSeleccionados(StringBuilder sb)
		{
			foreach (var item in from ListItem item in cblLenguajes.Items
								 where item.Selected
								 select item)
			{
				sb.Append(item.Text + "<br/>");
			}
		}
	}
}