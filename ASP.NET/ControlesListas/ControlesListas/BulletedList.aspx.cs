using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class BulletedList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (!IsPostBack)
			{
				CargarElementos();
			}

		}

		private void CargarElementos()
		{
			// Cargar la lista de elementos
			//List<HyperLink> elementos = new List<HyperLink>();

			//HyperLink link = new HyperLink();
			//link.Text = "Periodico";
			//link.NavigateUrl = "http://www.periodico.com";
			//elementos.Add(link);
			//HyperLink link2 = new HyperLink();
			//link2.Text = "Revista";
			//link2.NavigateUrl = "http://www.revista.com";
			//elementos.Add(link2);


			//// Asignar la lista al control BulletedList
			//BulletdList.DataSource = elementos;
			//BulletdList.DataBind();
		}

		protected void BulletdList_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				// Cargar la lista de elementos
				foreach (BulletStyle style in Enum.GetValues(typeof(BulletStyle)))
				{
					BulletdList.Items.Add(style.ToString());
				}

			}

		}

		protected void BulletdList_Click(object sender, BulletedListEventArgs e)
		{
			// Obtener el elemento seleccionado
			string item = BulletdList.Items[e.Index].Text;

			BulletStyle style = (BulletStyle) Enum.Parse(typeof(BulletStyle), item);

			BulletdList.BulletStyle = style;	

			

			
			//Response.Redirect(item.Value);
		}
	}
}