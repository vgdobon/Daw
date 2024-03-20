using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysForms
{
	public partial class Form1 : Form
	{

		List<int> listNumber = new List<int>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			listNumber.Add(Convert.ToInt32(txtNumber.Text));

		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{

			int suma = listNumber.Sum(x => x);
			double promedio = listNumber.Average(x => x);

			lblSumaResultado.Text = suma.ToString();
			lblPromedio.Text = promedio.ToString();
			//Hacer la suma y el promedio

			DateTimePicker dateTimePicker1 = new DateTimePicker();
			DateTimePicker dateTimePicker2 = new DateTimePicker();
			dateTimePicker1.Value = DateTime.Now;
			dateTimePicker2.Value = new DateTime(2021, 12, 31);

			int daysCalculatesBetweenDates = (dateTimePicker2.Value - dateTimePicker1.Value).Days;


		}
	}
}
