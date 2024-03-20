namespace AplicacionExcritorio
{
	partial class Formulario
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
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			lblA = new Label();
			lblB = new Label();
			lblC = new Label();
			SuspendLayout();
			// 
			// btn1
			// 
			btn1.Location = new Point(12, 60);
			btn1.Name = "btn1";
			btn1.Size = new Size(94, 29);
			btn1.TabIndex = 0;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += button1_Click;
			// 
			// btn2
			// 
			btn2.Location = new Point(223, 60);
			btn2.Name = "btn2";
			btn2.Size = new Size(94, 29);
			btn2.TabIndex = 1;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += btn2_Click;
			// 
			// btn3
			// 
			btn3.Location = new Point(450, 60);
			btn3.Name = "btn3";
			btn3.Size = new Size(94, 29);
			btn3.TabIndex = 2;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += btn3_Click;
			// 
			// lblA
			// 
			lblA.AccessibleName = "labels";
			lblA.AutoSize = true;
			lblA.Location = new Point(12, 145);
			lblA.Name = "lblA";
			lblA.Size = new Size(19, 20);
			lblA.TabIndex = 3;
			lblA.Text = "A";
			// 
			// lblB
			// 
			lblB.AccessibleName = "labels";
			lblB.AutoSize = true;
			lblB.Location = new Point(223, 145);
			lblB.Name = "lblB";
			lblB.Size = new Size(18, 20);
			lblB.TabIndex = 4;
			lblB.Text = "B";
			// 
			// lblC
			// 
			lblC.AccessibleName = "labels";
			lblC.AutoSize = true;
			lblC.Location = new Point(450, 145);
			lblC.Name = "lblC";
			lblC.Size = new Size(18, 20);
			lblC.TabIndex = 5;
			lblC.Text = "C";
			// 
			// Formulario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblC);
			Controls.Add(lblB);
			Controls.Add(lblA);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn1);
			Name = "Formulario";
			Text = "Formulario";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn1;
		private Button btn2;
		private Button btn3;
		private Label lblA;
		private Label lblB;
		private Label lblC;
	}
}