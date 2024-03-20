using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void bntLaunch_Click(object sender, EventArgs e)
		{
			Int32 nCaras = Convert.ToInt32(txtCaras.Text);
			Int32 nTiradas = Convert.ToInt32(txtTiradas.Text);
			Int32[] resultados = new Int32[nCaras];
			resultados[0] = 0;
			System.Random randomNumber = new System.Random();
			Control[] labels = new Control[nCaras];
			int xPosition = 10;
			int yPosition;
			int yPositionSum = 0;


			for (int i = 0; i < nTiradas; i++)
			{
				int newRandom = randomNumber.Next(nCaras);
				resultados[newRandom]= resultados[newRandom]+1;
			}

			for (int i = 0; i < nCaras; i++)
			{
				Label nuevaLabel = new Label();
				nuevaLabel.Text = (i+1).ToString() + ": " + resultados[i];
				

				if (i % 10 == 0 && i!=0)
				{
					xPosition = xPosition + 40;
					yPositionSum++;
				}

				yPosition = 100 + ((i- 10 * yPositionSum) * 20);


				nuevaLabel.Location = new Point(xPosition,yPosition);
				nuevaLabel.AutoSize = true;
				labels[i] = nuevaLabel;
			}

			Controls.AddRange(labels);

		}
	}
}
