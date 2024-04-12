using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingPrueba
{
	public partial class frmNorthWind : System.Web.UI.Page
	{

		private string stringConection = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				//Definir los objetos ADO.NET para seleccionar productos
				string selectSQL = "SELECT [Nombre del producto], [Id] FROM Productos";

				OleDbConnection con = new OleDbConnection(stringConection);

				OleDbCommand sqlCommand = new OleDbCommand(selectSQL, con);

				try
				{

					con.Open();

					//Definir el enlace
					ddlProductos.DataSource = sqlCommand.ExecuteReader();
					ddlProductos.DataTextField = "Nombre del producto";
					ddlProductos.DataValueField = "Id";

					ddlProductos.DataBind();

					ddlProductos.SelectedIndex = -1;

				}
				catch (Exception ex)
				{
					lblSalida.Text = ex.Message;

				}
				finally
				{

					con.Close();
				}


			}
		}

		protected void ddlProductos_SelectedIndexChanged(object sender, EventArgs e)
		{
			string SelectProducto = "SELECT [Nombre del producto], [Cantidad por unidad]," +
				"Categoría FROM Productos WHERE Id=@id";

			string id = ddlProductos.SelectedItem.Value.ToString();

			OleDbConnection conection = new OleDbConnection(stringConection);
			OleDbCommand cmd = new OleDbCommand(SelectProducto, conection);

			cmd.Parameters.AddWithValue("id", id);

			try
			{
				conection.Open();
				OleDbDataReader lector = cmd.ExecuteReader();
				lector.Read();

				lblRecordInfo.Text = "<b>Producto:</b> " + lector["Nombre del producto"] +
					"<br/><b>Cantidad: </b>" + lector["Cantidad por unidad"] +
					"<br/><b>Categoría:</b>: " + lector["Categoría"];

				string categoria = lector["Categoría"].ToString();
				lector.Close();

				string selectCategoria = "SELECT DISTINCT Categoría FROM Productos";

				OleDbCommand cmdOle = new OleDbCommand(selectCategoria, conection);

				//OleDbDataReader oleDbDataReader = cmdOle.ExecuteReader();
				lstCategoria.DataSource = cmdOle.ExecuteReader();
				lstCategoria.DataTextField = "Categoría";
				lstCategoria.DataBind();

				lstCategoria.Items.FindByText(categoria).Selected = true;

				pnlCategoria.Visible = true;

				/*while (oleDbDataReader != null)
				{
					ListItem ls = new ListItem();
					ls.Text = oleDbDataReader.GetString(0);

					lstCategoria.Items.Add(ls);
				}*/
			}
			catch (Exception ex)
			{
				lblSalida.Text += ex.Message;

			}
			finally
			{

				conection.Close();
			}
		}

		protected void cmdUpdate_Click(object sender, EventArgs e)
		{
			string categoriaSeleccionada = lstCategoria.SelectedItem.Value.ToString();
			string idProductoSeleccionado = ddlProductos.SelectedItem.Value;

			string updateCommand = "UPDATE Productos " + "SET Categoría = @categ " +
				" WHERE id= @id";


			OleDbConnection conection = new OleDbConnection(this.stringConection);
			OleDbCommand cmd = new OleDbCommand(updateCommand, conection);

			conection.Open();

			cmd.Parameters.AddWithValue("@categ", categoriaSeleccionada);
			cmd.Parameters.AddWithValue("@id", idProductoSeleccionado);

			cmd.ExecuteNonQuery();

			conection.Close();

			
		}
	}
}