using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysForms
{
	public partial class FormateoString : Form
	{
		Boolean negrita = false;
		Boolean cursiva = false;
		Boolean mayusculas = false;
		Boolean subrayado = false;
		String frase= "";

		Dictionary<String, String> ropa = new Dictionary<String, String>();
		Dictionary<String, String> talla = new Dictionary<String, String>();
		Dictionary<String, String> color = new Dictionary<String, String>();
		

		public FormateoString()
		{
			InitializeComponent();
			ropa.Add("01", "pantalón");
			ropa.Add("02", "camisa");
			ropa.Add("03", "camiseta");

			talla.Add("S", "pequeña");
			talla.Add("M", "mediana");
			talla.Add("L", "grande");

			color.Add("NG", "negro");
			color.Add("RJ", "rojo");
			color.Add("BL","blanco");
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			//Poner la frase en negrita conservando el estilo
			if (checkBox1.Checked)
			{
				negrita = true;
			}
			else
			{
				negrita = false;
			}



			//poner la frase de txtFrase en lblSalida
			Salida(negrita, cursiva, mayusculas, subrayado);
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			//poner la frase en cursiva
			if (checkBox2.Checked)
			{
				cursiva = true;
			}
			else
			{
				cursiva = false;
			}

			//poner la frase de txtFrase en lblSalida
			Salida(negrita, cursiva, mayusculas, subrayado);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			//Poner la frase en subrayado
			if (checkBox3.Checked)
			{
				mayusculas = true;

			}
			else
			{
				mayusculas = false;
			}

			//poner la frase de txtFrase en lblSalida
			Salida(negrita,	cursiva, mayusculas,subrayado);
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			//Poner la frase en subrayado
			if (checkBox4.Checked)
			{
				subrayado = true;
			}
			else
			{
				subrayado = false;
			}

			Salida(negrita, cursiva, mayusculas, subrayado);
		}

		private void Salida(Boolean negrita, Boolean cursiva, Boolean mayusculas,Boolean subrayado)
		{
			FontStyle estilo = FontStyle.Regular;

			if (negrita)
			{
				estilo |= FontStyle.Bold;
			}
			if (cursiva)
			{
				estilo |= FontStyle.Italic;
			}
			if(subrayado)
			{
				estilo |= FontStyle.Underline;
			}

			if (mayusculas)
			{
				txtFrase.Text = txtFrase.Text.ToUpper();
			}else{
				txtFrase.Text = txtFrase.Text.ToLower();
			}
			lblSalida.Font = new Font(lblSalida.Font, estilo);
			lblSalida.Text = txtFrase.Text;
		}

		private void btnSeparate_Click(object sender, EventArgs e)
		{
			String[] fraseSeparada = txtFrase.Text.Split(Convert.ToChar(lblChar.Text));
            foreach (var item in fraseSeparada)
            {
                lblSalidaSeparada.Text += item + "\n";
            }
        }

		private void btnExtraer_Click(object sender, EventArgs e)
		{
			int inicio = txtFrase.Text.IndexOf(txtInicio.Text);
			int final = txtFrase.Text.LastIndexOf(txtFinal.Text);

			if (inicio != -1 && final != -1)
			{
				lblSalidaExtraccion.Text = txtFrase.Text.Substring(inicio, final - inicio + txtFinal.Text.Length);
			}
			else
			{
				lblSalidaExtraccion.Text = "No se ha encontrado la cadena";
			}
		}

		private void btnComprar_Click(object sender, EventArgs e)
		{
			String[] strings = txtCodigoArticulo.Text.Split('/');
			String prenda = this.ropa[strings[0]];
			String talla = this.talla[strings[2]];
			String color = this.color[strings[1]];

			lblSalidaArticulo.Text = "Has comprado un " + prenda + " de talla " + talla + " y color " + color;
		}
	}
}
