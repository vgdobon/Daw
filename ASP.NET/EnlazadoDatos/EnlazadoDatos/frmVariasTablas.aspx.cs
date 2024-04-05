using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnlazadoDatos
{
	public partial class frmVariasTablas : System.Web.UI.Page
	{

		private string conexion = WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) {
				CrearLista();
			}
		}

		private void CrearLista()
		{
			string selectSQL = "SELECT au_lname, au_fname, au_id FROM authors";

			SqlConnection con = new SqlConnection(conexion);
			SqlCommand cmd = new SqlCommand(selectSQL, con);

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataSet dataSetPub = new DataSet();

			

			try
			{
				con.Open();
				adapter.Fill(dataSetPub, "Autores");

				cmd.CommandText = "SELECT au_id, title_id FROM titleauthor";
				adapter.Fill(dataSetPub, "TitleAuthor");

				cmd.CommandText = "SELECT title_id, title FROM titles";
				adapter.Fill(dataSetPub, "Titles");

				



			}
			catch (Exception ex)
			{
				lblList.Text = "Error al leer los datos" + ex.Message;

			}
			finally
			{
				//cmd.Dispose();
				//adapter.Dispose();
				con.Close();
			}

			DataRelation Titles_TitleAuthor_Relation = new DataRelation("Titles_TitleAuthor_Relation",
				dataSetPub.Tables["Titles"].Columns["title_id"],
				dataSetPub.Tables["TitleAuthor"].Columns["title_id"]);
		

			DataRelation Author_TitleAuthor_Relation = new DataRelation("Author_TitleAuthor_Relation",
				dataSetPub.Tables["Autores"].Columns["au_id"],
				dataSetPub.Tables["TitleAuthor"].Columns["au_id"]);

			dataSetPub.Relations.Add(Titles_TitleAuthor_Relation);
			dataSetPub.Relations.Add(Author_TitleAuthor_Relation);

			foreach (DataRow filaAutor in dataSetPub.Tables["Autores"].Rows) {

				
				lblList.Text += "<b>" + filaAutor["au_fname"].ToString() + " " + filaAutor["au_lname"].ToString() + "</b><br/>";

				foreach (DataRow filaTituloAutor in filaAutor.GetChildRows(Author_TitleAuthor_Relation))
				{
					DataRow filaTitulo = 
						filaTituloAutor.GetParentRows(Titles_TitleAuthor_Relation)[0];

					lblList.Text +=  filaTitulo["title"] + "<br />";


				}

			}

		}
	}
}