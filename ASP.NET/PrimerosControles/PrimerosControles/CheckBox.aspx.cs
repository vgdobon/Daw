using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerosControles
{
	public partial class CheckBox : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        
		protected void Subrayado_CheckedChanged(object sender, EventArgs e)
		{
			if(Subrayado.Checked)
			{
				Label1.Font.Underline = true;
			}
			else
			{
				Label1.Font.Underline = false;
			}

		}

		protected void Sobrerayado_CheckedChanged(object sender, EventArgs e)
		{
			if(Sobrerayado.Checked)
			{
				Label1.Font.Overline = true;
			}
			else
			{
				Label1.Font.Overline = false;
			}
		}

		protected void Tachado_CheckedChanged(object sender, EventArgs e)
		{
			if(Tachado.Checked)
			{
				Label1.Font.Strikeout = true;
			}
			else
			{
				Label1.Font.Strikeout = false;
			}
		}


		protected void Size_CheckedChanged(object sender, EventArgs e)
		{
			string btnText = ((RadioButton)sender).Text;

			int size = Convert.ToInt32(btnText.Substring(0,2));

			Label1.Font.Size = size;
		}
	}
}