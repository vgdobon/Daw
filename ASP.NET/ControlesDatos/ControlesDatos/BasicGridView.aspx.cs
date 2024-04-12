using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesDatos
{
	public partial class BasicGridView : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			/*if (!IsPostBack)
			{
				string cadena = WebConfigurationManager.ConnectionStrings["northwind"].ConnectionString;

				string selecSQL = "SELECT ID,[Product Name], [List Price] FROM Products";

				OleDbConnection con = new OleDbConnection(cadena);
				OleDbCommand cmd = new OleDbCommand(selecSQL, con);
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);

				DataSet ds = new DataSet();

				da.Fill(ds, "Products");

				GridViewSalida.DataSource = ds;
				GridViewSalida.DataBind();





			}*/
		}
	}
}