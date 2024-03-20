using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class frmTabla : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			string str = "Hoy es jueves y mañana será viernes";

			bool boolUnderline = false;
			bool boolOverline = false;
			bool boolStrike = false;

			foreach (ListItem item in this.cblFontStyle.Items)
			{
				if (item.Selected)
				{
					switch (item.Value)
					{
						case "u":
							boolUnderline = true;
							break;
						case "o":
							boolOverline = true;
							break;
						case "s":
							boolStrike = true;
							break;
					}
				}
			}

			//Obtienes el tamaño de la fuente

			int size = 
				Convert.ToInt32(rblSize.SelectedItem.Value);

			//Obtener una lista con las fuentes instaladas
			//en el sistema y rellenar con el texto de ejemplo

			InstalledFontCollection fonts = new InstalledFontCollection();
			fonts.Families.ToList().ForEach(f =>
			{
				TableRow row = new TableRow();
				TableCell cell = new TableCell();
				TableCell celText = new TableCell();
				cell.Text = f.Name;
				celText.Text = str;
				celText.Font.Underline = boolUnderline;
				celText.Font.Overline = boolOverline;
				celText.Font.Strikeout = boolStrike;
				celText.Font.Size = size;
				celText.Font.Name = f.Name;
				row.Cells.Add(cell);
				row.Cells.Add(celText);
				this.tblFontStyle.Rows.Add(row);
			});


		}

		protected void cblFontStyle_Init(object sender, EventArgs e)
		{
			//Crear matriz de elementos para añadirla

			string[] estilos = { "Subrayado" , "Sobrerayado", "Tachado" };
			string[] code = {"u", "o","s"};

			//Añadir elementos a la lista
			for(int i = 0; i < estilos.GetLength(0); i++)
			{
				this.cblFontStyle.Items.Add(new ListItem(estilos[i], code[i]));
			}
		}

		protected void tblFontStyle_Init(object sender, EventArgs e)
		{

		}

		protected void rblSize_Init(object sender, EventArgs e)
		{

		}
	}
}