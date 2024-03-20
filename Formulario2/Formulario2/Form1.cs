using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double longitud;
			double area;
			double volumen;
			double radio;

			radio = Double.Parse(txtRadio.Text);

			longitud = 2* Math.PI * radio;
			area = Math.PI * Math.Pow(radio,2);
			volumen = 4/3 * Math.PI * Math.Pow(radio,3);

			txtLongitud.Text += ": " +  longitud;
			txtSuperficie.Text += ": " + area;
			txtVolumen.Text += ": " + volumen;
		}

		private void btnDescomponer_Click(object sender, EventArgs e)
		{
			Double valor = Convert.ToDouble(txtValor.Text);
			int billetes50 = 0;
			int billetes20 = 0;
			int billetes10 = 0;
			int billetes5 = 0;
			int monedas2 = 0;
			int monedas1 = 0;

			int valorResidual;

			billetes50 = Convert.ToInt32(Math.Floor(valor/50));
			valor = valor - billetes50 * 50;
			billetes20 = Convert.ToInt32(Math.Floor(valor /20));
			valor = valor - billetes20 * 20;
			billetes10 = Convert.ToInt32(Math.Floor(valor / 10));
			valor = valor - billetes10 * 10;
			billetes5 = Convert.ToInt32(Math.Floor(valor / 5));
			valor = valor - billetes5 * 5;
			monedas2 = Convert.ToInt32(Math.Floor(valor / 2));
			valor = valor - monedas2 * 2;
			monedas1 = Convert.ToInt32(Math.Floor(valor / 1));
			valor = valor - monedas1 * 1;

			lbl50.Text += ": " + billetes50;
			label20.Text += ": " + billetes20;
			label10.Text += ": " + billetes10;
			lbl5.Text += ": " + billetes5;
			lbl2.Text += ": " + monedas2;
			lbl1.Text += ": " + monedas1;



		}
	}
}
