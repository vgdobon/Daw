using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion
{
	public partial class ProbarValidacion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnValidar_Click(object sender, EventArgs e)
        {
			string errorMessage = "<b>Errores encontrados: </b><br/>";

			bool pageIsValed = true;

			//Buscar entre los controles de validación
			//foreach (IValidator control in this.Controls.OfType<IValidator>())
			foreach (BaseValidator control in this.Validators)			{
				control.Validate();
				if (!control.IsValid)
				{
					pageIsValed = false;
					errorMessage += control.ErrorMessage + "<br/>";


					TextBox tb = this.FindControl(control.ControlToValidate) as TextBox;

					errorMessage += " * Problema con esta entrada: " + 
									tb.Text + "<br/>";
				}

				if(!pageIsValed)
				{
					lblMensaje.Text = errorMessage;
				}
				else
				{
					lblMensaje.Text = "No hay errores";
				}

			}
        }
    }
}