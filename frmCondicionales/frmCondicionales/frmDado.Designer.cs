namespace frmCondicionales
{
	partial class frmDado
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
			this.pictBoxDado = new System.Windows.Forms.PictureBox();
			this.btnLaunch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxDado)).BeginInit();
			this.SuspendLayout();
			// 
			// pictBoxDado
			// 
			this.pictBoxDado.Location = new System.Drawing.Point(328, 86);
			this.pictBoxDado.Name = "pictBoxDado";
			this.pictBoxDado.Size = new System.Drawing.Size(302, 270);
			this.pictBoxDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictBoxDado.TabIndex = 0;
			this.pictBoxDado.TabStop = false;
			// 
			// btnLaunch
			// 
			this.btnLaunch.Location = new System.Drawing.Point(141, 131);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(123, 83);
			this.btnLaunch.TabIndex = 1;
			this.btnLaunch.Text = "Launch";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// frmDado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLaunch);
			this.Controls.Add(this.pictBoxDado);
			this.Name = "frmDado";
			this.Text = "frmDado";
			((System.ComponentModel.ISupportInitialize)(this.pictBoxDado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictBoxDado;
		private System.Windows.Forms.Button btnLaunch;
	}
}