namespace TrabajoCshar
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
			this.lblTemperatura = new System.Windows.Forms.Label();
			this.txtTemperatura = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnCentigrados = new System.Windows.Forms.Button();
			this.btnFahrenheit = new System.Windows.Forms.Button();
			this.lblCentigrados = new System.Windows.Forms.Label();
			this.lblFahrenheit = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTemperatura
			// 
			this.lblTemperatura.AutoSize = true;
			this.lblTemperatura.Location = new System.Drawing.Point(138, 67);
			this.lblTemperatura.Name = "lblTemperatura";
			this.lblTemperatura.Size = new System.Drawing.Size(85, 16);
			this.lblTemperatura.TabIndex = 0;
			this.lblTemperatura.Text = "Temperatura";
			// 
			// txtTemperatura
			// 
			this.txtTemperatura.Location = new System.Drawing.Point(256, 67);
			this.txtTemperatura.Name = "txtTemperatura";
			this.txtTemperatura.Size = new System.Drawing.Size(100, 22);
			this.txtTemperatura.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnCentigrados
			// 
			this.btnCentigrados.Location = new System.Drawing.Point(148, 121);
			this.btnCentigrados.Name = "btnCentigrados";
			this.btnCentigrados.Size = new System.Drawing.Size(122, 23);
			this.btnCentigrados.TabIndex = 3;
			this.btnCentigrados.Text = "Centigrados";
			this.btnCentigrados.UseVisualStyleBackColor = true;
			this.btnCentigrados.Click += new System.EventHandler(this.btnCentigrados_Click);
			// 
			// btnFahrenheit
			// 
			this.btnFahrenheit.Location = new System.Drawing.Point(302, 121);
			this.btnFahrenheit.Name = "btnFahrenheit";
			this.btnFahrenheit.Size = new System.Drawing.Size(119, 23);
			this.btnFahrenheit.TabIndex = 4;
			this.btnFahrenheit.Text = "Fahrenheit";
			this.btnFahrenheit.UseVisualStyleBackColor = true;
			this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
			// 
			// lblCentigrados
			// 
			this.lblCentigrados.AutoSize = true;
			this.lblCentigrados.Location = new System.Drawing.Point(201, 161);
			this.lblCentigrados.Name = "lblCentigrados";
			this.lblCentigrados.Size = new System.Drawing.Size(0, 16);
			this.lblCentigrados.TabIndex = 5;
			// 
			// lblFahrenheit
			// 
			this.lblFahrenheit.AutoSize = true;
			this.lblFahrenheit.Location = new System.Drawing.Point(329, 161);
			this.lblFahrenheit.Name = "lblFahrenheit";
			this.lblFahrenheit.Size = new System.Drawing.Size(0, 16);
			this.lblFahrenheit.TabIndex = 6;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(60, 161);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(0, 16);
			this.lblResultado.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblFahrenheit);
			this.Controls.Add(this.lblCentigrados);
			this.Controls.Add(this.btnFahrenheit);
			this.Controls.Add(this.btnCentigrados);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTemperatura);
			this.Controls.Add(this.lblTemperatura);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTemperatura;
		private System.Windows.Forms.TextBox txtTemperatura;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCentigrados;
		private System.Windows.Forms.Button btnFahrenheit;
		private System.Windows.Forms.Label lblCentigrados;
		private System.Windows.Forms.Label lblFahrenheit;
		private System.Windows.Forms.Label lblResultado;
	}
}

