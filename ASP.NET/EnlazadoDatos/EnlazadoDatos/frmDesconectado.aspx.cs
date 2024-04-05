using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnlazadoDatos
{
	public partial class frmDesconectado : System.Web.UI.Page
	{

		private void RellenarAutores()
		{
			if (Page.IsPostBack == false)
			{
				string selectSQL = "Select au_lname, au_fname, au_id from authors";
				SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=pubs;Integrated Security=False;Connect Timeout=30;Encrypt=False");
				SqlCommand cmd = new SqlCommand(selectSQL, con);

				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
				DataSet dataSet = new DataSet();

				try
				{
					con.Open();
					sqlDataAdapter.Fill(dataSet, "Autores");

				}
				catch (Exception ex)
				{
					lblSalida.Text = ex.Message;
				}
				finally {
					con.Close();

				}


				foreach (DataRow fila in dataSet.Tables["Autores"].Rows)
				{
					ListItem newItem = new ListItem();
					newItem.Text = fila["au_lname"] + " " + fila["au_fname"];
					newItem.Value = fila["au_id"].ToString();

					lstAutor.Items.Add(newItem);
				}

			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			RellenarAutores();
		}
	}
}