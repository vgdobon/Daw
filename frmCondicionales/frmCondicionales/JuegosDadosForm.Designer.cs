namespace frmCondicionales
{
	partial class JuegosDadosForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox0 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.lblSalida = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(750, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(194, 169);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox0
			// 
			this.pictureBox0.Location = new System.Drawing.Point(495, 42);
			this.pictureBox0.Name = "pictureBox0";
			this.pictureBox0.Size = new System.Drawing.Size(176, 169);
			this.pictureBox0.TabIndex = 1;
			this.pictureBox0.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(1015, 42);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(166, 169);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// btnLaunch
			// 
			this.btnLaunch.Location = new System.Drawing.Point(177, 74);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(155, 84);
			this.btnLaunch.TabIndex = 3;
			this.btnLaunch.Text = "Play";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// lblSalida
			// 
			this.lblSalida.Location = new System.Drawing.Point(468, 325);
			this.lblSalida.Name = "lblSalida";
			this.lblSalida.Size = new System.Drawing.Size(342, 72);
			this.lblSalida.TabIndex = 5;
			// 
			// JuegosDadosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1245, 532);
			this.Controls.Add(this.lblSalida);
			this.Controls.Add(this.btnLaunch);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox0);
			this.Controls.Add(this.pictureBox1);
			this.Name = "JuegosDadosForm";
			this.Text = "JuegosDadosForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox0;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.Label lblSalida;
	}
}