using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class frmCheckBoxList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void CheckBoxList1_Init(object sender, EventArgs e)
        {
			string [] genero = {"Ciencia ficción", "Novela", "Informática", "Historia",
				"Horticultura"};

			for (int i = 0; i < genero.Length; i++)
			{
				CheckBoxList1.Items.Add(new ListItem(genero[i]));

			}
        }

		protected void cbListDeportes_Init(object sender, EventArgs e)
		{
			string [] deportes = { "Fútbol", "Baloncesto", "Tenis", "Natación",
				"Voleibol" };

			string [] codigos = { "F", "B", "T", "N", "V" };

			for (int i = 0; i < deportes.Length; i++)
			{
				cbListDeportes.Items.Add(new ListItem(deportes[i], codigos[i]));

			}

			cbListDeportes.RepeatDirection = RepeatDirection.Horizontal;
			cbListDeportes.RepeatColumns = 3;
			cbListDeportes.CellPadding = 5;
			cbListDeportes.BackColor = System.Drawing.Color.LightGray;
			cbListDeportes.BorderColor = System.Drawing.Color.Black;
			cbListDeportes.BorderStyle = BorderStyle.Solid;
			cbListDeportes.BorderWidth = 1;
		}


		protected void cbdListFrutas_Init(object sender, EventArgs e)
		{
			string[] frutas = { "Manzana", "Pera", "Plátano", "Naranja",
				"Melocotón" ,"Melón"};

			

			cbdListFrutas.DataSource = frutas;
			cbdListFrutas.DataBind();



			cbdListFrutas.RepeatDirection = RepeatDirection.Horizontal;
			cbdListFrutas.RepeatColumns = 3;
			cbdListFrutas.CellPadding = 5;
			cbdListFrutas.BackColor = System.Drawing.Color.LightGray;
			cbdListFrutas.BorderColor = System.Drawing.Color.Black;
			cbdListFrutas.BorderStyle = BorderStyle.Solid;
			cbdListFrutas.BorderWidth = 1;

		}

		protected void cbdListFrutas_SelectedIndexChanged(object sender, EventArgs e)
		{

			StringBuilder sb = new StringBuilder("Has seleccionado: </br>");
			

			sb.Append("Has seleccionado: </br>");

			List<ListItem> seleccionados = cbdListFrutas.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
			if(seleccionados.Count > 0)
			{
				foreach (ListItem item in seleccionados)
				{
					sb.Append(item.Text + "</br>");
				}
			}
			
			lblSalida.Text = sb.ToString();

		}

		protected void btnSB_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder(lblFrase.Text);

			

			sb.Append("</br> " + "Y pasado será miércoles");
			Thread.Sleep(2000);

			sb.Insert(sb.Length, ".");
			Thread.Sleep(2000);

			sb.Replace("miércoles", "jueves");
			sb.Replace("pasado", "dentro de dos días");
			Thread.Sleep(2000);


			foreach(char c in sb.ToString())
			{
				//int pos = sb.Chars[c];
				//sb.Remove(pos, 0);
			}


		}
	}
}