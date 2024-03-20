using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesRicos
{
	public partial class frmProbarExcepcion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public void cmdCalcular_Click(object sender, EventArgs e)
		{
			try
			{
				int dividendo = Convert.ToInt32(TextBox1.Text);
				int divisor = Convert.ToInt32(TextBox2.Text);
				//int resultado = dividendo / divisor;

				decimal resultado = Dividir(dividendo, divisor);
				Label3.Text = resultado.ToString();
				Decimal n = new Decimal(0.56);
			}
			
			catch (FormatException ex)
			{
				
				//Cambiar el Message de una excepcion


				Label3.Text = "<h1>Message</h1> " + ex.Message;
				Label3.Text += "<br /><br /><br /> <h1>StackTrace</h1>" + ex.StackTrace;
				Label3.Text += "<br /><br /><br /> <h1>Source</h1>" + ex.Source;
				Label3.Text += "<br /><br /><br /> <h1>TargetSite</h1>" + ex.TargetSite;
				Label3.Text += "<br /><br /><br /> <h1>InnerException</h1>" + ex.InnerException;
				Label3.Text += "<br /><br /><br /> <h1>HelpLink</h1>" + ex.HelpLink;
				Label3.Text += "<br /><br /><br /> <h1>HResult</h1>" + ex.HResult;
				Label3.Text += "<br /><br /><br /> <h1>Data</h1>" + ex.Data;
			}
		}

		private decimal Dividir(int dividendo, int divisor)
		{
			if(divisor == 0)
			{
				DivideByZeroException divideByZeroException = new DivideByZeroException("Cuidado con el divisor, campeón!");

				throw divideByZeroException;
			}else{
				return dividendo / divisor;
			}
		}
	}
}