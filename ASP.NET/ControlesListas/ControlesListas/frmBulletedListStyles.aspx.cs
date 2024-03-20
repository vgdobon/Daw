using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesListas
{
	public partial class frmBulletedListStyles : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void DDLStyle_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				foreach (BulletStyle style in Enum.GetValues(typeof(BulletStyle)))
				{
					DDLStyle.Items.Add(style.ToString());
				}
			}
		}

		protected void DDLPrimerElemento_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				for (int i = 1; i < 10; i++)
				{
					DDLPrimerElemento.Items.Add(i.ToString());
				}
			}
		}

		protected void DDLDisplayMode_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				foreach (BulletedListDisplayMode mode in Enum.GetValues(typeof(BulletedListDisplayMode)))
				{
					DDLDisplayMode.Items.Add(mode.ToString());
				}
			}
		}

		protected void DDLStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			BulletedListDisplayMode mode = (BulletedListDisplayMode)Enum.Parse(typeof(BulletedListDisplayMode), DDLDisplayMode.SelectedValue);

			

			BulletedList1.DisplayMode = mode;

			BulletedList1.BulletStyle = (BulletStyle)Enum.Parse(typeof(BulletStyle), DDLStyle.SelectedValue);
			BulletedList1.FirstBulletNumber = int.Parse(DDLPrimerElemento.SelectedValue);

		}

		protected void BulletedList1_Load(object sender, EventArgs e)
		{
			BulletedList1.Target = "_blank";
		}

		protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
		{
			System.Web.UI.WebControls.BulletedList b =
				(System.Web.UI.WebControls.BulletedList)sender;


			string lb = b.Items[e.Index].Value;

			Page.Response.Redirect(lb);
			//Response.Redirect(b.Items[e.Index].);
			
		}
	}
}