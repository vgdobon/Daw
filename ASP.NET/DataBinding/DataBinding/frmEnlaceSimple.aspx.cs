using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



	public partial class frmEnlaceSimple : System.Web.UI.Page
	{
		
		public int NumT { get; set; }
		protected void Page_Load(object sender, EventArgs e)
		{
			this.NumT = 10;
			this.DataBind();
		}
	}
