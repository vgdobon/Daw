using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoAragon
{
	public partial class frmPlantas : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnBuscar_Click(object sender, EventArgs e)
		{
			OleDbConnection conexion = new OleDbConnection();
			conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Profesor\\Documents\\ProbarParametros.accdb";

			OleDbCommand comando = new OleDbCommand();
			comando.Connection = conexion;
			//comando.CommandText = "SELECT * FROM Datos WHERE Planta = @nombre";
			//comando.Parameters.AddWithValue("@nombre", txtPlanta.Text);

			//Insertar en la bd con parametros
			comando.CommandText = "INSERT INTO Datos (CodPlanta, Planta, Precio) VALUES (?,?,?)";
			comando.Parameters.Add(new OleDbParameter("@cod", "003"));
			comando.Parameters.Add(new OleDbParameter("@nombre", "Cactus"));
			comando.Parameters.Add(new OleDbParameter("@precio", 10.5));

			try
			{
				conexion.Open();
				comando.ExecuteNonQuery();
				lblResultado.Text = "Se ha insertado correctamente";

			}
			catch (Exception ex)
			{
				lblResultado.Text = "Error: " + ex.Message;
			}
			finally
			{
				conexion.Close();
			}



		}
	}
}