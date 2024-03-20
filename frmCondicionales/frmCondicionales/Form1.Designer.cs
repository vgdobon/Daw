namespace frmCondicionales
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.chkPapiroflexia = new System.Windows.Forms.CheckBox();
			this.chkHorticultura = new System.Windows.Forms.CheckBox();
			this.chkDactilografia = new System.Windows.Forms.CheckBox();
			this.chkNumismatica = new System.Windows.Forms.CheckBox();
			this.txtTotal = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(78, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Actividades";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(353, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(435, 209);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// chkPapiroflexia
			// 
			this.chkPapiroflexia.AutoSize = true;
			this.chkPapiroflexia.Location = new System.Drawing.Point(85, 178);
			this.chkPapiroflexia.Name = "chkPapiroflexia";
			this.chkPapiroflexia.Size = new System.Drawing.Size(100, 20);
			this.chkPapiroflexia.TabIndex = 2;
			this.chkPapiroflexia.Tag = "11";
			this.chkPapiroflexia.Text = "Papiroflexia";
			this.chkPapiroflexia.UseVisualStyleBackColor = true;
			this.chkPapiroflexia.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// chkHorticultura
			// 
			this.chkHorticultura.AutoSize = true;
			this.chkHorticultura.Location = new System.Drawing.Point(85, 205);
			this.chkHorticultura.Name = "chkHorticultura";
			this.chkHorticultura.Size = new System.Drawing.Size(96, 20);
			this.chkHorticultura.TabIndex = 3;
			this.chkHorticultura.Tag = "17";
			this.chkHorticultura.Text = "Horticultura";
			this.chkHorticultura.ThreeState = true;
			this.chkHorticultura.UseVisualStyleBackColor = true;
			this.chkHorticultura.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// chkDactilografia
			// 
			this.chkDactilografia.AutoSize = true;
			this.chkDactilografia.Location = new System.Drawing.Point(85, 232);
			this.chkDactilografia.Name = "chkDactilografia";
			this.chkDactilografia.Size = new System.Drawing.Size(105, 20);
			this.chkDactilografia.TabIndex = 4;
			this.chkDactilografia.Tag = "12";
			this.chkDactilografia.Text = "Dactilografia";
			this.chkDactilografia.UseVisualStyleBackColor = true;
			this.chkDactilografia.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// chkNumismatica
			// 
			this.chkNumismatica.AutoSize = true;
			this.chkNumismatica.Location = new System.Drawing.Point(85, 259);
			this.chkNumismatica.Name = "chkNumismatica";
			this.chkNumismatica.Size = new System.Drawing.Size(107, 20);
			this.chkNumismatica.TabIndex = 5;
			this.chkNumismatica.Tag = "10";
			this.chkNumismatica.Text = "Numismatica";
			this.chkNumismatica.UseVisualStyleBackColor = true;
			this.chkNumismatica.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.AutoSize = true;
			this.txtTotal.Location = new System.Drawing.Point(85, 354);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(41, 16);
			this.txtTotal.TabIndex = 6;
			this.txtTotal.Text = "Total:";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Location = new System.Drawing.Point(136, 354);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(44, 16);
			this.lblPrecio.TabIndex = 7;
			this.lblPrecio.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.chkNumismatica);
			this.Controls.Add(this.chkDactilografia);
			this.Controls.Add(this.chkHorticultura);
			this.Controls.Add(this.chkPapiroflexia);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox chkPapiroflexia;
		private System.Windows.Forms.CheckBox chkHorticultura;
		private System.Windows.Forms.CheckBox chkDactilografia;
		private System.Windows.Forms.CheckBox chkNumismatica;
		private System.Windows.Forms.Label txtTotal;
		private System.Windows.Forms.Label lblPrecio;
	}
}

