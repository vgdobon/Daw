using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesRicos
{
	public partial class frmTarjeta : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!this.IsPostBack)
			{
				//Establecer las opciones de color
				//lstBackColor.Items.Add("White");
				//lstBackColor.Items.Add("Red");
				//lstBackColor.Items.Add("Green");
				//lstBackColor.Items.Add("Blue");
				//lstBackColor.Items.Add("Yellow");
				//lstBackColor.Items.Add("Black");
				//lstBackColor.Items.Add("Gray");
				//lstBackColor.Items.Add("Orange");
				//lstBackColor.Items.Add("Purple");
				//lstBackColor.Items.Add("Brown");

				string[] colorNames = Enum.GetNames(typeof(KnownColor));
				lstBackColor.DataSource = colorNames;
				lstBackColor.DataBind();

				
				//Obtener la colección de fuentes instaladas

				InstalledFontCollection fonts = new InstalledFontCollection();

				foreach (FontFamily family in fonts.Families)
				{
					lstFontName.Items.Add(family.Name);
				}


				//Opciones para el borde
				ListItem li= new ListItem();

				//El texto del elemento indica el nombre de la opción
				li.Text = BorderStyle.None.ToString();

				//El valor del elemento registra el entero
				//correspondiente a la enumeración
				li.Value = ((int)BorderStyle.None).ToString();
				rblBorderStyle.Items.Add(li);




				//Repetir el proceso para cada elemento de la enumeración
				li = new ListItem();
				li.Text = BorderStyle.Dotted.ToString();
				li.Value = ((int)BorderStyle.Dotted).ToString();
				rblBorderStyle.Items.Add(li);
				
				li = new ListItem();
				li.Text = BorderStyle.Dashed.ToString();
				li.Value = ((int)BorderStyle.Dashed).ToString();
				rblBorderStyle.Items.Add(li);

				li = new ListItem();
				li.Text = BorderStyle.Solid.ToString();
				li.Value = ((int)BorderStyle.Solid).ToString();
				rblBorderStyle.Items.Add(li);

				li = new ListItem();
				li.Text = BorderStyle.Double.ToString();
				li.Value = ((int)BorderStyle.Double).ToString();
				rblBorderStyle.Items.Add(li);

				li = new ListItem();
				li.Text = BorderStyle.Groove.ToString();
				li.Value = ((int)BorderStyle.Groove).ToString();
				rblBorderStyle.Items.Add(li);

				li = new ListItem();
				li.Text = BorderStyle.Ridge.ToString();
				li.Value = ((int)BorderStyle.Ridge).ToString();
				rblBorderStyle.Items.Add(li);
			
				imgDefault.ImageUrl = "brocoli.jpg";

			}
		}

		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			//Actualizar el color
			pnlCard.BackColor = 
				System.Drawing.Color.FromName(lstBackColor.SelectedItem.Text);

			//Actualizar la fuente
			lblGreeting.Font.Name = 
				lstFontName.SelectedItem.Text;

			//Actualizar el tamaño de la fuente

			int tamanoFuente = Int32.TryParse(txtFontSize.Text, out int size) ? size : 12;


			FontUnit.Point(tamanoFuente);

			

			//Actualizar el borde
			pnlCard.BorderWidth = 
				Unit.Point(10);
			pnlCard.BorderStyle =
				(BorderStyle)Convert.ToInt32(rblBorderStyle.SelectedItem.Value);


			//Actualizar el texto
			lblGreeting.Text = txtGreeting.Text;

			//Actualizar la imagen
			if(chkPicture.Checked)
			{
				imgDefault.Visible = true;
			}
			else
			{
				imgDefault.Visible = false;
			}


		}
	}
}