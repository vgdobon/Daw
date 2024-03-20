using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionExcritorio
{
	public partial class Formulario : Form
	{
		public Formulario()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lblA.Text = "Si";
			lblB.Text = "Si";
			lblC.Text = "Si";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			lblA.Text = "No";
			lblB.Text = "No";
			lblC.Text = "No";
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			lblA.Text = "A";
			lblB.Text = "B";
			lblC.Text = "C";
		}
	}
}
