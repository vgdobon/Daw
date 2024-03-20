using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCondicionales
{
	public partial class JuegosDadosForm : Form
	{
		public JuegosDadosForm()
		{
			InitializeComponent();
		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{

			Image[] images = new Image[6];
			images[0] = new Bitmap(Properties.Resources.dado1);
			images[1] = new Bitmap(Properties.Resources.dado2);
			images[2] = new Bitmap(Properties.Resources.dado3);
			images[3] = new Bitmap(Properties.Resources.dado4);
			images[4] = new Bitmap(Properties.Resources.dado5);
			images[5] = new Bitmap(Properties.Resources.dado6);

			List<Image> listImgesRandom = new List<Image>();

			List<PictureBox> listPictureBox = new List<PictureBox>();
			listPictureBox.Add(pictureBox0);
			listPictureBox.Add(pictureBox1);
			listPictureBox.Add(pictureBox2);



			pictureBox0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

			//pictureBox0.Image = images[0];

			int[] listRandom = new int[3];
			int numeroRandom;

			int suma=0;


			for (int i = 0; i < 3; i++)
            {
				numeroRandom = new Random().Next(6);
                listRandom[i] = numeroRandom + 1;
				listImgesRandom.Add(images[numeroRandom]);
				System.Threading.Thread.Sleep(100);
			}

			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 30; j++)
				{
					int randomNumberImage = new Random().Next(6);
					listPictureBox[i].Image = images[randomNumberImage];
					System.Threading.Thread.Sleep(10 + j*10);
					this.Refresh();
				}
				listPictureBox[i].Image = listImgesRandom[i];
			}

			int numerosRepetidos = 0;

            for (int i = 0; i < 2; i++)
            {
				if (listRandom[i] == listRandom[i + 1])
				{
					numerosRepetidos++;
				}
            }

			if (numerosRepetidos == 1)
			{
				suma += 2;
			}
			else if (numerosRepetidos == 2)
			{
				suma += 6;
			}

            for (int i = 0; i < listRandom.Length; i++)
            {
				suma += listRandom[i];
            }


			if (suma >= 15)
			{
				lblSalida.Text = suma + ": Has ganado";
			}
			else
			{
				lblSalida.Text = suma + ": Has perdido";
			}

			this.Refresh();
		}

		

	}
}
