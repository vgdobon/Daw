using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingPrueba
{
	public partial class Editor_de_Registro : System.Web.UI.Page
	{

		private string con = WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;


		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string selectSQL = "SELECT title, price, title_id FROM  titles";

				SqlConnection conSql = new SqlConnection(con);
				SqlCommand cmd = new SqlCommand(selectSQL, conSql);

				conSql.Open();

				ddlProductos.DataSource = cmd.ExecuteReader();
				ddlProductos.DataTextField = "title";
				ddlProductos.DataValueField = "title_id";

				ddlProductos.DataBind();

				conSql.Close();

				ddlProductos.SelectedIndex = -1;



			}
		}
	}
}