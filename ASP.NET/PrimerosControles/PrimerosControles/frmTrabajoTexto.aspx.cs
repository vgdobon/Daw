using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerosControles
{
	public partial class frmTrabajoTexto : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
			
			string frase = txtFrase.Text;

			if(frase.Split(',').Length < 3 || frase.Split('.').Length < 3)
			{
				if(frase.Contains(".")) frase = frase.Replace(".", ",");
				
				if (decimal.TryParse(frase, out decimal numero))
				{
					numero = numero * 2;
					frase = numero.ToString();

				}
			}else{
				frase = "No es un número válido";
			}
			lblSalida.Text = frase;

		}

		protected void btnDiaHora_Click(object sender, EventArgs e)
		{
			DateTime fecha = DateTime.Now;

			lblSalida.Text = "Hoy es " + fecha.Day + " y son las " + fecha.Hour + ":" + fecha.Minute;
		}

		protected void btnTabla_Click(object sender, EventArgs e)
		{
			int numero;
			lblSalida.Text = "";

			if (int.TryParse(txtFrase.Text, out numero))
			{
				for (int i = 1; i <= 10; i++)
				{
					lblSalida.Text += numero + " x " + i + " = " + (numero * i) + "<br/>";
				}
			}
			else
			{
				lblSalida.Text = "No es un número entero";
			}
		}

		protected void Iniciar_Init(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.Text = "Hoy es Viernes y mañana será sábado";
			lbl.Font.Name = "Verdana";
			lbl.Font.Size = 20;
			lbl.Font.Underline = true;
			lbl.Font.Bold = true;
			lbl.Font.Italic = true;
			lbl.Font.Overline = true;
			lbl.Font.Strikeout = true;
		}
	}
}