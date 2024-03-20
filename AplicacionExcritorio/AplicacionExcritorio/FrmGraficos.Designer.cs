namespace AplicacionExcritorio
{
	partial class FrmGraficos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnDibujar = new Button();
			pictureBox1 = new PictureBox();
			btnLinea = new Button();
			btnElipse = new Button();
			btnRectanguloRelleno = new Button();
			btnElipseRellena = new Button();
			btnTriangulo = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnDibujar
			// 
			btnDibujar.Location = new Point(65, 52);
			btnDibujar.Name = "btnDibujar";
			btnDibujar.Size = new Size(164, 43);
			btnDibujar.TabIndex = 0;
			btnDibujar.Text = "Rectángulo";
			btnDibujar.UseVisualStyleBackColor = true;
			btnDibujar.Click += btnDibujar_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(344, 44);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(746, 522);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// btnLinea
			// 
			btnLinea.Location = new Point(65, 136);
			btnLinea.Name = "btnLinea";
			btnLinea.Size = new Size(164, 43);
			btnLinea.TabIndex = 2;
			btnLinea.Text = "Linea";
			btnLinea.UseVisualStyleBackColor = true;
			btnLinea.Click += btnLinea_Click;
			// 
			// btnElipse
			// 
			btnElipse.Location = new Point(65, 224);
			btnElipse.Name = "btnElipse";
			btnElipse.Size = new Size(164, 43);
			btnElipse.TabIndex = 3;
			btnElipse.Text = "Elipse";
			btnElipse.UseVisualStyleBackColor = true;
			btnElipse.Click += btnElipse_Click;
			// 
			// btnRectanguloRelleno
			// 
			btnRectanguloRelleno.Location = new Point(65, 310);
			btnRectanguloRelleno.Name = "btnRectanguloRelleno";
			btnRectanguloRelleno.Size = new Size(164, 73);
			btnRectanguloRelleno.TabIndex = 4;
			btnRectanguloRelleno.Text = "Rectángulo Relleno";
			btnRectanguloRelleno.UseVisualStyleBackColor = true;
			btnRectanguloRelleno.Click += btnRectanguloRelleno_Click;
			// 
			// btnElipseRellena
			// 
			btnElipseRellena.Location = new Point(65, 420);
			btnElipseRellena.Name = "btnElipseRellena";
			btnElipseRellena.Size = new Size(164, 43);
			btnElipseRellena.TabIndex = 5;
			btnElipseRellena.Text = "Elipse Rellena";
			btnElipseRellena.UseVisualStyleBackColor = true;
			btnElipseRellena.Click += btnElipseRellena_Click;
			// 
			// btnTriangulo
			// 
			btnTriangulo.Location = new Point(65, 501);
			btnTriangulo.Name = "btnTriangulo";
			btnTriangulo.Size = new Size(164, 43);
			btnTriangulo.TabIndex = 6;
			btnTriangulo.Text = "Triángulo";
			btnTriangulo.UseVisualStyleBackColor = true;
			btnTriangulo.Click += btnTriangulo_Click;
			// 
			// FrmGraficos
			// 
			AutoScaleDimensions = new SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1182, 578);
			Controls.Add(btnTriangulo);
			Controls.Add(btnElipseRellena);
			Controls.Add(btnRectanguloRelleno);
			Controls.Add(btnElipse);
			Controls.Add(btnLinea);
			Controls.Add(pictureBox1);
			Controls.Add(btnDibujar);
			Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5);
			Name = "FrmGraficos";
			Text = "FrmGraficos";
			Load += FrmGraficos_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnDibujar;
		private PictureBox pictureBox1;
		private Button btnLinea;
		private Button btnElipse;
		private Button btnRectanguloRelleno;
		private Button btnElipseRellena;
		private Button btnTriangulo;
	}
}