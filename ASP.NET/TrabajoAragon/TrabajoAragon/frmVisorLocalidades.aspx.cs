using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Web.Configuration;

namespace TrabajoAragon
{
	public partial class frmVisorLocalidades : System.Web.UI.Page
	{

		private String CadenaConexion = WebConfigurationManager.ConnectionStrings["aragon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{

			if (!IsPostBack)
			{

				RellenarLocalidades();
			}

		}

		private void RellenarLocalidades()
		{
			ddlLocalidades.Items.Clear();

			string sentencia = "SELECT DISTINCT Localidad from Pueblos";


			OleDbConnection con = new OleDbConnection(CadenaConexion);

			OleDbCommand cmd = new OleDbCommand(sentencia, con);
			OleDbDataReader reader;

			try
			{
				con.Open();
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					ddlLocalidades.Items.Add(reader["Localidad"].ToString());
				}

			}
			catch (Exception ex)
			{
				lblError.Text = "Error al rellenar el desplegable de localidades: " + ex.Message;
			}
			finally
			{
				con.Close();
			}


		}

		protected void ddlLocalidades_SelectedIndexChanged(object sender, EventArgs e)
		{
			String pueblo = ddlLocalidades.SelectedValue;

			string sentencia = "SELECT * from Pueblos WHERE Localidad  ='" + pueblo + "'";

			OleDbConnection con = new OleDbConnection(CadenaConexion);
			OleDbCommand cmd = new OleDbCommand(sentencia, con);
			OleDbDataReader reader;

			//cmd.Parameters.AddWithValue("@localidad", ddlLocalidades.SelectedValue);

			try
			{
				con.Open();
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					lblLocalidad.Text = pueblo + "<br/>";
					lblLocalidad.Text += "Comarca:" + reader["COMARCA"] + "<br/>";
					lblLocalidad.Text += "Provincia:" + reader["PROVINCIA"] + "<br/>";
					lblLocalidad.Text += "Habitantes:" + reader["HABITANTES"] + "<br/>";
					lblLocalidad.Text += "Altitud:" + reader["ALTITUD"] + "<br/>";
					lblLocalidad.Text += "Distancia:" + reader["DISTANCIA"] + "<br/>";

				}

			}
			catch (Exception ex)
			{
				lblError.Text = "Error al rellenar los datos del pueblo: " + ex.Message;
			}
			finally
			{
				con.Close();
			}

		}
	}
}