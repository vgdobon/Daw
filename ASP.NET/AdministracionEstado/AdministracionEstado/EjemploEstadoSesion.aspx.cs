using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstado
{
	public partial class EjemploEstadoSesion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				//Crear un objeto de tipo Mueble y almacenarlo en la sesión
				Mueble silla = new Mueble("Silla", "Silla de madera", 49.50M);
				Session["Silla"] = silla;

				Mueble mesa = new Mueble("Mesa", "Mesa de madera", 100.15M);
				Session["Mesa"] = mesa;

				Mueble sofa = new Mueble("Sofa", "Sofa de piel", 199.59M);
				Session["Sofa"] = sofa;

				Mueble cama = new Mueble("Cama", "Cama de matrimonio", 150.20M);
				Session["Cama"] = cama;

				Mueble mesilla = new Mueble("Mesilla", "Mesilla de noche", 30.40M);
				Session["Mesilla"] = mesilla;

				Mueble armario = new Mueble("Armario", "Armario de madera", 299.99M);
				Session["Armario"] = armario;

				//Añadir filar al ListBox


				ListItems.Items.Add(silla.Nombre);
				ListItems.Items.Add(mesa.Nombre);
				ListItems.Items.Add(sofa.Nombre);
				ListItems.Items.Add(cama.Nombre);
				ListItems.Items.Add(mesilla.Nombre);
				ListItems.Items.Add(armario.Nombre);
							
			}

			//Mostrar el precio del mueble seleccionado
			if (ListItems.SelectedIndex != -1)
			{
				Mueble mueble = (Mueble)Session[ListItems.SelectedItem.Text];
				lblSession.Text = "Precio: " + mueble.Precio.ToString("c");
				lblSession.Text += "<br/>Descripción: " + mueble.Descripcion;
				lblSession.Text += "<br/>Nombre: " + mueble.Nombre;
				lblSession.Text += "<br> Nombre de la sesión: " + Session.SessionID;
				lblSession.Text += "<br> Hora de inicio de la sesión: " + Session["HoraInicio"];
				lblSession.Text += "<br> Número de visitas: " + Session["Visitas"];
				lblSession.Text += "<br> Última visita: " + Session["UltimaVisita"];
				lblSession.Text += "<br> ¿Es cokielees?" + Session.IsCookieless.ToString();
				lblSession.Text += "<br> ¿Es nueva?" + Session.IsNewSession.ToString();
				lblSession.Text += "<br> ¿Es válida?" + Session.IsReadOnly.ToString();
				lblSession.Text += "<br> Expiración" + Session.Timeout.ToString();
			}
			
		}

		protected void btnSaveInfo_Click(object sender, EventArgs e)
		{
			if(ListItems.SelectedIndex != -1)
			{
				Mueble mueble = (Mueble)Session[ListItems.SelectedItem.Text];

				//Mostrar la información del mueble seleccionado
				lblMuebleInfo.Text = "Precio: " + mueble.Precio.ToString("c");
				lblMuebleInfo.Text += "<br/>Descripción: " + mueble.Descripcion;
				lblMuebleInfo.Text += "<br/>Nombre: " + mueble.Nombre;

			}else{
				lblSession.Text = "Seleccione un mueble";
			}
		}
	}
}