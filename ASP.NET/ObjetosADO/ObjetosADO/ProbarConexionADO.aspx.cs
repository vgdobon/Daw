using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Xml.Linq;

namespace ObjetosADO
{
	public partial class ProbarConexionADO : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void buttonProbarConection_Click(object sender, EventArgs e)
        {
			//Crear la conexion con accdb

			OleDbConnection conexion = new OleDbConnection(
				@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Profesor\Documents\GitHub\DesarrolloAplicacionesCertificado\ASP.NET\ObjetosADO\ObjetosADO\aragon.accdb");
			try
			{
				conexion.Open();
				labelResultado.Text = "Conexion exitosa</br>";

				//Obtener las tablas de la base de datos
				labelResultado.Text += "Tablas : <br/>";
				foreach (System.Data.DataRow fila in conexion.GetSchema("Tables").Rows)
				{
					labelResultado.Text += fila["TABLE_NAME"].ToString() + "<br>";
				}
				//Obtener las vistas de la base de datos
				foreach (System.Data.DataRow fila in conexion.GetSchema("Views").Rows)
				{
					labelResultado.Text += fila["TABLE_NAME"].ToString() + "<br>";
				}



				//Obtener las columnas de la tabla
				labelResultado.Text += "<br/> Columnas de la tabla Pueblos : <br/>";
				OleDbCommand comando = new OleDbCommand("SELECT * FROM Pueblos where PROVINCIA='Huesca'", conexion);
				OleDbDataReader lector = comando.ExecuteReader();
				for (int i = 0; i < lector.FieldCount; i++)
				{
					labelResultado.Text += lector.GetName(i) + "<br>";
				}

				//Obtener los datos de la tabla
				labelResultado.Text += "<br/> Datos de la tabla Pueblos : <br/>";
				while (lector.Read())
				{
					labelResultado.Text += lector["LOCALIDAD"].ToString() + "-->" + lector["PROVINCIA"].ToString() + "<br>";
				}
			}
			catch
			{
				labelResultado.Text  += "Conexion fallida";
			}
			finally
			{
				conexion.Close();
			}
        }
    }
}