using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingPrueba
{
	public partial class DataSetBinding : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//Definir un DataSet con un sola tabla

			DataSet dataSetInternal = new DataSet();
			dataSetInternal.Tables.Add("Usuarios");

			//Definir dos columnas para esa tabla
			dataSetInternal.Tables["Usuarios"].Columns.Add("Nombre");
			dataSetInternal.Tables["Usuarios"].Columns.Add("País");

			//Añadir filas a la tabla
			DataRow fila = dataSetInternal.Tables["Usuarios"].NewRow();
			fila["Nombre"] = "Francisco";
			fila["País"] = "España";
			dataSetInternal.Tables["Usuarios"].Rows.Add(fila);

			fila = dataSetInternal.Tables["Usuarios"].NewRow();
			fila["Nombre"] = "Jean";
			fila["País"] = "Inglés";
			dataSetInternal.Tables["Usuarios"].Rows.Add(fila);

			fila = dataSetInternal.Tables["Usuarios"].NewRow();
			fila["Nombre"] = "Raúl";
			fila["País"] = "Mexico";
			dataSetInternal.Tables["Usuarios"].Rows.Add(fila);

			fila = dataSetInternal.Tables["Usuarios"].NewRow();
			fila["Nombre"] = "KinJun";
			fila["País"] = "Corea";
			dataSetInternal.Tables["Usuarios"].Rows.Add(fila);

			//Definir el enlace
			lstUsuarios.DataSource = dataSetInternal;
			lstUsuarios.DataMember = "Usuarios";
			lstUsuarios.DataTextField = "País";
			lstUsuarios.DataTextFormatString = "Usuarios" + "País";

			lstUsuarios.DataBind();
		}
	}
}