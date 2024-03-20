using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoAragon
{
	public partial class AutorManager : System.Web.UI.Page
	{
		string connectionString = WebConfigurationManager.ConnectionStrings["pubs"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				RellenarAutores();
			}

		}

		private void RellenarAutores()
		{
			ddlAutores.Items.Clear();

			string selectSQL = "SELECT au_id, au_lname,au_fname FROM authors";

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = new SqlCommand(selectSQL, sqlConnection);

			SqlDataReader reader;

			try
			{
				sqlConnection.Open();
				reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					ListItem newItem = new ListItem();
					newItem.Text = reader["au_lname"] + ", " + reader["au_fname"];
					newItem.Value = reader["au_id"].ToString();
					ddlAutores.Items.Add(newItem);
				}
				reader.Close();
			}
			catch (Exception err)
			{
				lblError.Text = "Error al rellenar autores";
				lblError.Text += err.Message;
			}
			finally
			{
				sqlConnection.Close();
			}


		}

		protected void ddlAutores_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectSQL = "SELECT * FROM authors WHERE au_id = '" + ddlAutores.SelectedItem.Value + "'";

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = new SqlCommand(selectSQL, sqlConnection);
			SqlDataReader reader;

			try
			{
				sqlConnection.Open();
				reader = sqlCommand.ExecuteReader();

				reader.Read();

				//Rellenar los campos con los datos del autor seleccionado
				txtId.Text = reader["au_id"].ToString();
				txtApellido.Text = reader["au_lname"].ToString();
				txtNombre.Text = reader["au_fname"].ToString();
				txtTelefono.Text = reader["phone"].ToString();
				txtDireccion.Text = reader["address"].ToString();
				txtCiudad.Text = reader["city"].ToString();
				txtEstado.Text = reader["state"].ToString();
				txtCodigoPostal.Text = reader["zip"].ToString();

				if (reader["contract"].ToString() == "True")
				{
					chkActivo.Checked = true;
				}
				else
				{
					chkActivo.Checked = false;
				}

				reader.Close();

			}
			catch (Exception err)
			{
				lblError.Text += err.Message;
			}
			finally
			{
				sqlConnection.Close();
			}


		}

		protected void btnActualizar_Click(object sender, EventArgs e)
		{
			//Recoger los datos de los campos
			string id = txtId.Text;
			string apellido = txtApellido.Text;
			string nombre = txtNombre.Text;
			string telefono = txtTelefono.Text;
			string direccion = txtDireccion.Text;
			string ciudad = txtCiudad.Text;
			string estado = txtEstado.Text;
			string codigoPostal = txtCodigoPostal.Text;
			bool activo = chkActivo.Checked;

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string updateSQL = "UPDATE authors SET au_lname = '" + apellido + "', au_fname = '" + nombre + "', phone = '" + telefono + "', address = '" + direccion + "', city = '" + ciudad + "', state = '" + estado + "', zip = '" + codigoPostal + "', contract = '" + activo + "' WHERE au_id = '" + id + "'";
			SqlCommand sqlCommand = new SqlCommand(updateSQL, sqlConnection);

			try
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				lblError.Text = "Autor actualizado correctamente";
			}
			catch (Exception err)
			{
				lblError.Text = "Error al actualizar autor";
				lblError.Text += err.Message;
			}
			finally
			{
				sqlConnection.Close();
				RellenarAutores();
			}

		}

		protected void btnBorrar_Click(object sender, EventArgs e)
		{
			string idAutor = ddlAutores.SelectedItem.Value;

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string deleteSQL = "DELETE FROM authors WHERE au_id = '" + idAutor + "'";
			SqlCommand sqlCommand = new SqlCommand(deleteSQL, sqlConnection);

			sqlCommand.Parameters.Clear();

			try
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				lblError.Text = "Autor borrado correctamente";
			}
			catch (Exception err)
			{
				lblError.Text = "Error al borrar autor";
				lblError.Text += err.Message;
			}
			finally
			{
				sqlConnection.Close();
				RellenarAutores();
			}

		}

		protected void btnCrearNuevo_Click(object sender, EventArgs e)
		{
			//Limpiar los campos
			txtId.Text = "";
			txtApellido.Text = "";
			txtNombre.Text = "";
			txtTelefono.Text = "";
			txtDireccion.Text = "";
			txtCiudad.Text = "";
			txtEstado.Text = "";
			txtCodigoPostal.Text = "";
			chkActivo.Checked = false;

		}

		protected void btnInsertar_Click(object sender, EventArgs e)
		{
			//Recoger los datos de los campos
			string id = txtId.Text;
			string apellido = txtApellido.Text;
			string nombre = txtNombre.Text;
			string telefono = txtTelefono.Text;
			string direccion = txtDireccion.Text;
			string ciudad = txtCiudad.Text;
			string estado = txtEstado.Text;
			string codigoPostal = txtCodigoPostal.Text;
			bool activo = chkActivo.Checked;

			if(id == "" || apellido == "" || nombre == "")
			{
				lblError.Text = "El id, apellido y nombre son obligatorios";
				return;
			}

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string insertSQL = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract)" +
				"VALUES ('" + id + "', '" + apellido + "', '" + nombre + "', '" 
				+ telefono + "', '" + direccion + "', '" + ciudad + "', '" 
				+ estado + "', '" + codigoPostal + "', '" + activo + "')";
			SqlCommand sqlCommand = new SqlCommand(insertSQL, sqlConnection);

			try
			{

				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				lblError.Text = "Autor insertado correctamente";
			}
			catch (Exception err)
			{
				lblError.Text = "Error al insertar autor";
				lblError.Text += err.Message;
			}
			finally
			{
				sqlConnection.Close();
				RellenarAutores();
			}




		}
	}
}