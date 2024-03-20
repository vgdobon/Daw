using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
    public partial class CrossPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null) {
                lblInfo.Text = "Tu vienes de la página " +
                    PreviousPage.Title + "<br/><br/>";

                CrossPage1 prevPage = PreviousPage as CrossPage1;

                if (prevPage != null)
                {
                    lblInfo.Text += "Eres " + prevPage.FullName;
                }
            }
        }
    }
}