namespace Formulario2
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
			this.components = new System.ComponentModel.Container();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblRadio = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.txtLongitud = new System.Windows.Forms.Label();
			this.txtSuperficie = new System.Windows.Forms.Label();
			this.txtVolumen = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDescomponer = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl50 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(368, 55);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblRadio
			// 
			this.lblRadio.AutoSize = true;
			this.lblRadio.Location = new System.Drawing.Point(175, 58);
			this.lblRadio.Name = "lblRadio";
			this.lblRadio.Size = new System.Drawing.Size(44, 16);
			this.lblRadio.TabIndex = 1;
			this.lblRadio.Text = "Radio";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtRadio
			// 
			this.txtRadio.Location = new System.Drawing.Point(225, 56);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(100, 22);
			this.txtRadio.TabIndex = 3;
			// 
			// txtLongitud
			// 
			this.txtLongitud.AutoSize = true;
			this.txtLongitud.Location = new System.Drawing.Point(175, 115);
			this.txtLongitud.Name = "txtLongitud";
			this.txtLongitud.Size = new System.Drawing.Size(58, 16);
			this.txtLongitud.TabIndex = 4;
			this.txtLongitud.Text = "Longitud";
			// 
			// txtSuperficie
			// 
			this.txtSuperficie.AutoSize = true;
			this.txtSuperficie.Location = new System.Drawing.Point(175, 152);
			this.txtSuperficie.Name = "txtSuperficie";
			this.txtSuperficie.Size = new System.Drawing.Size(67, 16);
			this.txtSuperficie.TabIndex = 5;
			this.txtSuperficie.Text = "Superficie";
			// 
			// txtVolumen
			// 
			this.txtVolumen.AutoSize = true;
			this.txtVolumen.Location = new System.Drawing.Point(175, 184);
			this.txtVolumen.Name = "txtVolumen";
			this.txtVolumen.Size = new System.Drawing.Size(60, 16);
			this.txtVolumen.TabIndex = 6;
			this.txtVolumen.Text = "Volumen";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(287, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 32);
			this.label1.TabIndex = 7;
			this.label1.Text = "Esfera";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(242, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "Descomposición";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(225, 294);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 22);
			this.txtValor.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(175, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Valor";
			// 
			// btnDescomponer
			// 
			this.btnDescomponer.Location = new System.Drawing.Point(368, 294);
			this.btnDescomponer.Name = "btnDescomponer";
			this.btnDescomponer.Size = new System.Drawing.Size(109, 29);
			this.btnDescomponer.TabIndex = 11;
			this.btnDescomponer.Text = "Descomponer";
			this.btnDescomponer.UseVisualStyleBackColor = true;
			this.btnDescomponer.Click += new System.EventHandler(this.btnDescomponer_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(125, 347);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 32);
			this.label4.TabIndex = 12;
			this.label4.Text = "Billetes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(518, 347);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 32);
			this.label5.TabIndex = 13;
			this.label5.Text = "Monedas";
			// 
			// lbl50
			// 
			this.lbl50.AutoSize = true;
			this.lbl50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl50.Location = new System.Drawing.Point(128, 409);
			this.lbl50.Name = "lbl50";
			this.lbl50.Size = new System.Drawing.Size(27, 20);
			this.lbl50.TabIndex = 14;
			this.lbl50.Text = "50";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label20.Location = new System.Drawing.Point(128, 442);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(27, 20);
			this.label20.TabIndex = 15;
			this.label20.Text = "20";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(128, 477);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(27, 20);
			this.label10.TabIndex = 16;
			this.label10.Text = "10";
			// 
			// lbl5
			// 
			this.lbl5.AutoSize = true;
			this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl5.Location = new System.Drawing.Point(128, 509);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(18, 20);
			this.lbl5.TabIndex = 17;
			this.lbl5.Text = "5";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(510, 409);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(18, 20);
			this.lbl2.TabIndex = 18;
			this.lbl2.Text = "2";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(510, 442);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(18, 20);
			this.lbl1.TabIndex = 19;
			this.lbl1.Text = "1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 560);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.lbl50);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnDescomponer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtVolumen);
			this.Controls.Add(this.txtSuperficie);
			this.Controls.Add(this.txtLongitud);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.lblRadio);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRadio;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.Label txtLongitud;
		private System.Windows.Forms.Label txtSuperficie;
		private System.Windows.Forms.Label txtVolumen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDescomponer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl50;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
	}
}

