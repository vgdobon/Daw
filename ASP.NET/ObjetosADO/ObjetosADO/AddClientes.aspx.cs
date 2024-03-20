using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObjetosADO
{
	public partial class AddClientes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void buttonAddClient_Click(object sender, EventArgs e)
		{
			SqlConnection conexion = new SqlConnection();

			try
			{

				conexion.ConnectionString =
				"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Clientes;Integrated Security=True;Pooling=False;Encrypt=False;";

				conexion.Open();
				string cadena = "INSERT INTO Clientes (IdCliente, NombreCliente, ApellidoCliente, " +
					"EdadCliente, Direccion, CodPOstal)" +
					" VALUES('5','Elena','Muñiz',34,'Avenida Castellón','50059'";

				SqlCommand comando = new SqlCommand();
				comando.Connection = conexion;
				comando.CommandText = cadena;

				if (comando.ExecuteNonQuery() > 0)
				{
					Response.Write("Cliente añadido correctamente");
				}
				else
				{
					Response.Write("Error al añadir el cliente");
				}


			}
			catch (Exception ex)
			{
				Response.Write("Error: " + ex.Message);
				Response.Close();
			}
			finally
			{
				conexion.Close();
			}
		}
    }
}