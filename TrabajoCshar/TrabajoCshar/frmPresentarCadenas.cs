using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoCshar
{
	public partial class frmPresentarCadenas : Form
	{
		public frmPresentarCadenas()
		{
			InitializeComponent();
		}

		private void btnPresentar_Click(object sender, EventArgs e)
		{
			int resultado = 5/2 + 5/2;
			lblResultado.Text = resultado.ToString();


		}
	}
}
