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
	public partial class FrmGraficos : Form
	{

		
		Pen pen;

		public FrmGraficos()
		{
			InitializeComponent();
		}

		private void FrmGraficos_Load(object sender, EventArgs e)
		{

		}

		private void btnDibujar_Click(object sender, EventArgs e)
		{
			Graphics Papel = pictureBox1.CreateGraphics();
			pen = new Pen(Color.BlueViolet);
			Papel.Clear(Color.White);



			Papel.DrawRectangle(pen, 10, 10, 100, 50);
			Papel.DrawRectangle(pen, 10, 70, 100, 50);

		}

		private void btnLinea_Click(object sender, EventArgs e)
		{
			Graphics Papel = pictureBox1.CreateGraphics();
			Papel.Clear(Color.White);
			pen = new Pen(Color.Orange, 10f);

			Papel.DrawLine(pen, 20, 20, 200, 20);
		}

		private void btnElipse_Click(object sender, EventArgs e)
		{
			Graphics Papel = pictureBox1.CreateGraphics();
			pen = new Pen(Color.White, 10f);
			Papel.Clear(Color.Aquamarine);

			Papel.DrawEllipse(pen, 50, 50, 400, 200);
		}

		private void btnRectanguloRelleno_Click(object sender, EventArgs e)
		{
			Brush brush = new SolidBrush(Color.IndianRed);
			Graphics Papel = pictureBox1.CreateGraphics();
			pen = new Pen(Color.IndianRed, 10f);
			Papel.Clear(Color.Gold);

			Papel.FillRectangle(brush, 10, 10, 150, 150);
		}

		private void btnElipseRellena_Click(object sender, EventArgs e)
		{
			Brush brush = new SolidBrush(Color.IndianRed);
			Graphics Papel = pictureBox1.CreateGraphics();
			pen = new Pen(Color.IndianRed, 10f);
			Papel.Clear(Color.Gold);

			Papel.FillEllipse(brush, 10, 10, 150, 250);

		}

		private void btnTriangulo_Click(object sender, EventArgs e)
		{

			Graphics Papel = pictureBox1.CreateGraphics();
			Papel.Clear(Color.White);
			pen = new Pen(Color.Orange, 10f);

			Papel.DrawLine(pen, 50, 350, 350, 350);
			Papel.DrawLine(pen, 50, 350, 200, 50);
			Papel.DrawLine(pen, 200, 50, 350, 350);

		}
	}
}
