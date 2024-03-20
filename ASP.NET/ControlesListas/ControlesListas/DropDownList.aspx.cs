using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class DropDownList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (!IsPostBack)
			{
				CargarLibros();
			}
		}

		private void CargarLibros()
		{
			myList.Items.Add(new ListItem("El Quijote", "25.45"));
			myList.Items.Add(new ListItem("El Señor de los Anillos", "35.45"));
			myList.Items.Add(new ListItem("El Perfume", "15.45"));
			myList.Items.Add(new ListItem("El Código Da Vinci", "45.45"));
			myList.Items.Add(new ListItem("El Perfume", "15.45"));
			myList.Items.Add(new ListItem("Capitán Alatriste", "12.45"));
			myList.Items.Add(new ListItem("Romeo y Julieta", "19.45"));
			myList.Items.Add(new ListItem("Charlie y la fabrica de chocolate", "18.45"));
		}

		protected void MyList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListItem item = myList.SelectedItem;

			StringBuilder sb = new StringBuilder();
			sb.Append("Libro: " + item.Text + "<br/>");
			sb.Append("Precio: " + myList.SelectedValue + "<br/>");

			lblSalida.Text = sb.ToString();
		}
	}
}