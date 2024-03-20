using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoCshar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Grados centígrados = (grados Fahrenheit − 32) × 5/9.
		
		private void btnCentigrados_Click(object sender, EventArgs e)
		{
			lblFahrenheit.Text = "";
			Double fahrenheit = Convert.ToDouble(txtTemperatura.Text);

			lblCentigrados.Text = Convert.ToString( (fahrenheit - 32) *5/9);
			lblResultado.Text = fahrenheit.ToString();
			

		}

		//Grados Fahrenheit = (grados centígrados × 9/5) +32
		private void btnFahrenheit_Click(object sender, EventArgs e)
		{
			lblCentigrados.Text = "";
			Double centigrados = Convert.ToDouble(txtTemperatura.Text);

			lblFahrenheit.Text = Convert.ToString((centigrados * 9/5) +32 );
			lblResultado.Text = centigrados.ToString();

		}
	}
}
