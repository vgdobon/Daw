using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnlazadoDatos
{
	public partial class frmProductos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				rellenarProductos();
			}
		}

		private void rellenarProductos()
		{
			ddlProductos.Items.Clear();


			string cadena =
				"SELECT IdProducto , Producto FROM Articulos";
			SqlConnection con = new SqlConnection("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog = libreria; Integrated Security = False");
			SqlCommand cmd = new SqlCommand(cadena, con);

			SqlDataReader aa;

			try
			{

				con.Open();
				aa = cmd.ExecuteReader();
				//aa = cmd.ExecuteReader();

				while (aa.Read())
				{
					ListItem newItem = new ListItem();
					newItem.Text = aa["Producto"].ToString();
					newItem.Value = aa["IdProducto"].ToString();

					ddlProductos.Items.Add(newItem);
				}

				aa.Close();
			}
			catch (InvalidOperationException ex)
			{

				lblSalida.Text = "Error al cargar los productos: \n"
					+ ex.Message + ex.StackTrace;
			}
			finally
			{
				con.Close();
			}


		}

		protected void ddlProductos_SelectedIndexChanged(object sender, EventArgs e)
		{
			string cadena =
					"SELECT * From Articulos where IdProducto = @idProducto";
			SqlConnection con = new SqlConnection("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog = libreria; Integrated Security = False;");
			SqlCommand cmd = new SqlCommand(cadena, con);

			//cmd.Parameters.AddWithValue("@IdProducto", ddlProductos.SelectedValue);
			cmd.Parameters.AddWithValue("@idProducto", ddlProductos.SelectedItem.Value);

			SqlDataReader dr;


			try
			{
				con.Open();
				dr = cmd.ExecuteReader();
				dr.Read();

				txtIdProducto.Text = dr["IdProducto"].ToString();
				txtProducto.Text = dr["Producto"].ToString();
				txtCategoria.Text = dr["Categoria"].ToString();
				txtSubcategoria.Text = dr["Subcategoria"].ToString();
				txtPrecio.Text = dr["Precio"].ToString();
				txtEntrega.Text = dr["Entrega"].ToString();
				dr.Close();

			}
			catch (InvalidOperationException ex)
			{
				lblSalida.Text = ex.Message;

			}
			finally
			{
				con.Close();
			}



		}

		protected void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtIdProducto.Text = "";
			txtCategoria.Text = "";
			txtSubcategoria.Text = "";
			txtProducto.Text = "";
			txtPrecio.Text = "";
			txtEntrega.Text = "";

		}

		protected void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txtIdProducto.Text == "" || txtIdProducto.Text == "")
			{
				lblSalida.Text = "Debes rellenar el Id y el nombre de producto";
				return;
			}

			string cadena = "INSERT INTO Articulos (IdProducto, Categoria, Subcategoria, Producto, " +
				"Precio, Entrega) VALUES (@id, @categoria, @subcategoria, @producto, @precio, @entrega)";

			SqlConnection con = new SqlConnection("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog = libreria; Integrated Security = False;");
			SqlCommand cmd = new SqlCommand(cadena, con);

			cmd.Parameters.AddWithValue("@id", txtIdProducto.Text);
			cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
			cmd.Parameters.AddWithValue("@subcategoria", txtSubcategoria.Text);
			cmd.Parameters.AddWithValue("@producto", txtIdProducto.Text);
			cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
			cmd.Parameters.AddWithValue("@entrega", txtEntrega.Text);

			int add = 0;

			try
			{
				con.Open();
				add = cmd.ExecuteNonQuery();

				lblSalida.Text = "Has Añadido " + add + " registro";
			}
			catch (Exception ex)
			{
				lblSalida.Text = ex.Message;
			}
			finally
			{
				con.Close();
			}

			rellenarProductos();

		}

		protected void btnBorrar_Click(object sender, EventArgs e)
		{
			string id = txtIdProducto.Text;

			string cadena = "DELETE FROM ARTICULOS WHERE IDPRODUCTO = @idProductoEliminar";

			SqlConnection con = new SqlConnection("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog = libreria; Integrated Security = False;");
			SqlCommand cmd = new SqlCommand(cadena, con);

			cmd.Parameters.AddWithValue("@idProductoEliminar", id);

			try
			{

				con.Open();

				int eliminados = cmd.ExecuteNonQuery();


				if (eliminados == 1)
				{
					lblSalida.Text = "Su producto ha sido eliminado";
				}
				else if (eliminados == 0)
				{
					lblSalida.Text = "No se ha eliminado ningun producto";
				}
				else
				{
					lblSalida.Text = "Ha eliminado varios productos";
				}

				rellenarProductos();

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

		protected void btnActualizar_Click(object sender, EventArgs e)
		{

			string cadena = "UPDATE Articulos SET " +
				" Categoria = @categoria, Subcategoria = @subcategoria, Producto = @producto, " +
				" Precio = @precio, Entrega = @entrega where IdProducto = @idProducto";


			SqlConnection con = new SqlConnection("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog = libreria; Integrated Security = False;");
			SqlCommand cmd = new SqlCommand(cadena, con);

			cmd.Parameters.AddWithValue("@idProducto", txtIdProducto.Text);
			cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
			cmd.Parameters.AddWithValue("@subcategoria", txtSubcategoria.Text);
			cmd.Parameters.AddWithValue("@producto", txtProducto.Text);
			cmd.Parameters.AddWithValue("@precio", float.Parse(txtPrecio.Text));
			cmd.Parameters.AddWithValue("@entrega", txtEntrega.Text);


			try
			{

				con.Open();

				lblSalida.Text = "Ha actualizado " + cmd.ExecuteNonQuery() + " registros";
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

		protected void btnInfo_Click(object sender, EventArgs e)
		{
			string NumeroProductos;
			string cadenaContarProductos =
				"Select count(IdProducto) from Articulos";

			string NumeroCategoria;
			string cadenaContarCategorias =
				"Select count(distinct Categoria) from articulos";

			string PromedioPrecios;
			string cadenaPromedioPrecios =
				"Select avg(Precio) from Articulos";

			string MaximoPrecio;
			string cadenaMaximoPrecio =
				"Select Max(Precio) from Articulos";

			string MinimoPrecio;
			string cadenaMinimoPrecio =
				"Select Min(Precio) from Articulos";
			SqlConnection con = new SqlConnection("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog = libreria; Integrated Security = False;");

			//SqlCommand cmd = new SqlCommand(cadena, con);

			try
			{
				con.Open();

				try
				{
					SqlCommand cmd = new SqlCommand(cadenaContarProductos, con);
					NumeroProductos = cmd.ExecuteScalar().ToString();
					lblInfo.Text = "Número de productos:" + NumeroProductos + "</br>";

				}
				catch (Exception es)
				{
					lblSalida.Text = es.Message;
				}
				finally { }


				try
				{
					SqlCommand cmd = new SqlCommand(cadenaContarCategorias, con);
					NumeroCategoria = cmd.ExecuteScalar().ToString();
					lblInfo.Text += "Número de categorias:" + NumeroCategoria + "</br>";

				}
				catch (Exception es)
				{
					lblSalida.Text = es.Message;
				}
				finally
				{ }

				try
				{
					SqlCommand cmd = new SqlCommand(cadenaPromedioPrecios, con);
					PromedioPrecios = ((Double)cmd.ExecuteScalar()).ToString("#,#00,00");

					lblInfo.Text += "Precio promedio:" + PromedioPrecios + "</br>";

				}
				catch (Exception es)
				{
					lblSalida.Text = es.Message;
				}
				finally
				{ }

				try
				{
					SqlCommand cmd = new SqlCommand(cadenaMaximoPrecio, con);
					MaximoPrecio = cmd.ExecuteScalar().ToString();
					lblInfo.Text += "Maximo precio:" + MaximoPrecio + "</br>";

				}
				catch (Exception es)
				{
					lblSalida.Text = es.Message;
				}
				finally
				{ }

				try
				{
					SqlCommand cmd = new SqlCommand(cadenaMinimoPrecio, con);
					MinimoPrecio = cmd.ExecuteScalar().ToString();
					lblInfo.Text += "Minimo precio:" + MinimoPrecio;

				}
				catch (Exception es)
				{
					lblSalida.Text = es.Message;
				}
				finally
				{ }
			}
			catch (Exception ex)
			{
				lblSalida.Text += ex.Message;
			}

			finally
			{ }
		}



	}
}