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
	public partial class frmDado : Form
	{
		public frmDado()
		{
			InitializeComponent();
		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			int tirada = random.Next(6);

			Image[] images = new Image[6];
			images[0] = new Bitmap(Properties.Resources.dado1);
			images[1] = new Bitmap(Properties.Resources.dado2);
			images[2] = new Bitmap(Properties.Resources.dado3);
			images[3] = new Bitmap(Properties.Resources.dado4);
			images[4] = new Bitmap(Properties.Resources.dado5);
			images[5] = new Bitmap(Properties.Resources.dado6);

			pictBoxDado.SizeMode = PictureBoxSizeMode.StretchImage;
			pictBoxDado.Image = images[tirada];

		}
	}
}
