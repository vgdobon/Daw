using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
    public partial class RetenerInfo : System.Web.UI.Page
    {
        private string contenidos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack) {
                //restaurar las variables
                contenidos = (string)ViewState["valorEstado"];
            }
        }

        protected void Page_PreRender(object sender, EventArgs e) {
            //Persistir las variables
            ViewState["valorEstado"] = contenidos;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Transferir los contenidos del cuadro de texto a la variable
            contenidos = txtValor.Text;
            txtValor.Text = "";
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            //Colocar los contenidos de la variable en el TextBox
            txtValor.Text = contenidos;
        }
    }
}