using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCondicionales
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Int32 sumatorio = 0;

            foreach (Control item in Controls)
            {
				if (item.GetType().Name == "CheckBox")
				{

					if (((CheckBox)item).Checked)
					{
						sumatorio += Convert.ToInt32(((CheckBox)item).Tag);
					}
				}

            }


			lblPrecio.Text = sumatorio.ToString();
        }

	}
}
