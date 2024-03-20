using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion
{
	public partial class FormularioPersonalizado : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
			if(Page.IsValid)
			{
				lblMessage.Text = "Formulario válido";
			}
			else
			{
				lblMessage.Text = "Formulario inválido";
			}

        }

		protected void btnReset_Click(object sender, EventArgs e)
		{
			txtUserName.Text = "";
			txtPassword.Text = "";
			txtPassword2.Text = "";
			txtEmail.Text = "";
			txtPhone.Text = "";
			txtAge.Text = "";
			txtCode.Text = "";
			
			lblMessage.Text = "Limpiado";

		}

		protected void customValidatorCode_ServerValidate(object source, ServerValidateEventArgs args)
		{
			try
			{
				int val = Int32.Parse(args.Value.Substring(0, 3));

				if (val % 7 == 0)
				{
					args.IsValid = true;
				}
				else
				{
					args.IsValid = false;
				}
			}
			catch (Exception ex)
			{
				args.IsValid = false;
				lblMessage.Text = ex.Message;
			}
			

			
		}
	}
}