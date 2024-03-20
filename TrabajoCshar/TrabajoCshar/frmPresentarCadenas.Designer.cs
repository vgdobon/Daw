namespace TrabajoCshar
{
	partial class frmPresentarCadenas
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
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnPresentar = new System.Windows.Forms.Button();
			this.lblDirectorio = new System.Windows.Forms.Label();
			this.lblTable = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblResultado
			// 
			this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblResultado.Location = new System.Drawing.Point(95, 55);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Padding = new System.Windows.Forms.Padding(10);
			this.lblResultado.Size = new System.Drawing.Size(273, 57);
			this.lblResultado.TabIndex = 0;
			// 
			// btnPresentar
			// 
			this.btnPresentar.Location = new System.Drawing.Point(98, 133);
			this.btnPresentar.Name = "btnPresentar";
			this.btnPresentar.Size = new System.Drawing.Size(75, 23);
			this.btnPresentar.TabIndex = 1;
			this.btnPresentar.Text = "Presentar Salida";
			this.btnPresentar.UseVisualStyleBackColor = true;
			this.btnPresentar.Click += new System.EventHandler(this.btnPresentar_Click);
			// 
			// lblDirectorio
			// 
			this.lblDirectorio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblDirectorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDirectorio.Location = new System.Drawing.Point(98, 223);
			this.lblDirectorio.Name = "lblDirectorio";
			this.lblDirectorio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblDirectorio.Size = new System.Drawing.Size(270, 29);
			this.lblDirectorio.TabIndex = 2;
			// 
			// lblTable
			// 
			this.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTable.Location = new System.Drawing.Point(98, 318);
			this.lblTable.Name = "lblTable";
			this.lblTable.Size = new System.Drawing.Size(328, 153);
			this.lblTable.TabIndex = 3;
			// 
			// frmPresentarCadenas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 562);
			this.Controls.Add(this.lblTable);
			this.Controls.Add(this.lblDirectorio);
			this.Controls.Add(this.btnPresentar);
			this.Controls.Add(this.lblResultado);
			this.Name = "frmPresentarCadenas";
			this.Text = "frmPresentarCadenas";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnPresentar;
		private System.Windows.Forms.Label lblDirectorio;
		private System.Windows.Forms.Label lblTable;
	}
}