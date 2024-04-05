using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnlazadoDatos
{
	public partial class frmControlRepeater : System.Web.UI.Page
	{
		OleDbConnection con {get;set;}
		OleDbDataAdapter adapter {get;set;}
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Profesor\\Downloads\\aragon.accdb");
			adapter = new OleDbDataAdapter("SELECT localidad, municipio, comarca, provincia, habitantes, altitud FROM Pueblos;", con);

			DataSet dataSetPueblos = new DataSet();
			adapter.Fill(dataSetPueblos, "pueblosDS");

			rptLocalidades.DataSource = dataSetPueblos.Tables["pueblosDS"];

			rptLocalidades.DataBind();
			
		}
	}
}