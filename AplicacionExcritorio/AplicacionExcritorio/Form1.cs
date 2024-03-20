namespace AplicacionExcritorio
{
	public partial class MyForm : Form
	{
		public MyForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void MyButton_Click(object sender, EventArgs e)
		{
			MyLabel.Text = "Acabas de hacer click en el botón";
			MyLabel.BackColor = Color.Red;
			MyLabel.ForeColor = Color.White;
			MyLabel.Location = new Point(
				Top
				);

		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{

			String Texto = "Dimensiones \nAncho:" + Dimensiones.Width +
				"\nAlto: " + Dimensiones.Height;
			Dimensiones.Text = Texto;
			MessageBox.Show(Texto);
		}
	}
}
