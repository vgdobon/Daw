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
	public partial class tablaDeMultiplicar : Form
	{
		public tablaDeMultiplicar()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Button boton = (Button)sender;
			String name = boton.Name;
			var numero = Convert.ToInt32(listBox1.Text);
			Control[] list = new Control[11];

			for (int i = 0; i <= 10; i++)
			{
				Control label = new Label();
				label.AutoSize = true;
				label.Name = "lblNumero"+i.ToString();
				label.Text = $"{numero} * {i} = {numero * i}";
				label.Location = new Point(55, i * 15 + 100);
				list[i] = label;
				//Controls.Add(label);
			}
			
			Controls.AddRange(list);

			/*foreach (Control label in list)
			{
				Controls.Add(label);
			}*/

		}
	}
}
