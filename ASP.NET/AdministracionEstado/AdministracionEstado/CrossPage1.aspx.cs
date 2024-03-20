using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
    public partial class CrossPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string FullName
        {
            get
            {
                return txtNombre.Text + " " + txtApellido.Text;
            }
        }
    }
}