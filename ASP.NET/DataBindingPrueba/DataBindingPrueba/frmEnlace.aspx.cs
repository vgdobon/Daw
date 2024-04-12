using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingPrueba
{
	[DataBindingHandler]
	public partial class frmEnlace : System.Web.UI.Page
	{
		
		private int Num { get; set; }
		protected void Page_Load(object sender, EventArgs e)
		{
			this.Num = 2;

		}

		public int getNumber()
		{
			return this.Num;
		}

		
	}
}