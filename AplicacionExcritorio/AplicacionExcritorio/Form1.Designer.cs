namespace AplicacionExcritorio
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			MyLabel = new Label();
			MyBoton = new Button();
			Dimensiones = new Label();
			btnMostrar = new Button();
			SuspendLayout();
			// 
			// MyLabel
			// 
			MyLabel.Font = new Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			MyLabel.Location = new Point(31, 28);
			MyLabel.Name = "MyLabel";
			MyLabel.Size = new Size(344, 33);
			MyLabel.TabIndex = 0;
			MyLabel.Text = "Esto es una etiqueta";
			MyLabel.Click += label1_Click;
			// 
			// MyBoton
			// 
			MyBoton.Font = new Font("Segoe UI", 12F);
			MyBoton.Location = new Point(400, 19);
			MyBoton.Margin = new Padding(3, 4, 3, 4);
			MyBoton.Name = "MyBoton";
			MyBoton.Size = new Size(237, 51);
			MyBoton.TabIndex = 1;
			MyBoton.Text = "Cambiar fondo";
			MyBoton.UseVisualStyleBackColor = true;
			MyBoton.Click += MyButton_Click;
			// 
			// Dimensiones
			// 
			Dimensiones.AutoSize = true;
			Dimensiones.Location = new Point(82, 161);
			Dimensiones.Name = "Dimensiones";
			Dimensiones.Size = new Size(50, 20);
			Dimensiones.TabIndex = 2;
			Dimensiones.Text = "label1";
			// 
			// btnMostrar
			// 
			btnMostrar.Location = new Point(466, 164);
			btnMostrar.Name = "btnMostrar";
			btnMostrar.Size = new Size(94, 29);
			btnMostrar.TabIndex = 3;
			btnMostrar.Text = "button1";
			btnMostrar.UseVisualStyleBackColor = true;
			btnMostrar.Click += btnMostrar_Click;
			// 
			// MyForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(btnMostrar);
			Controls.Add(Dimensiones);
			Controls.Add(MyBoton);
			Controls.Add(MyLabel);
			Margin = new Padding(3, 4, 3, 4);
			Name = "MyForm";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label MyLabel;
        private Button MyBoton;
		private Label Dimensiones;
		private Button btnMostrar;
	}
}
