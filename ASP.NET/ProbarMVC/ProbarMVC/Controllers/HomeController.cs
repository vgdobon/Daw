using ProbarMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProbarMVC.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			int hora = DateTime.Now.Hour;
			ViewBag.Saludo = hora < 12 ? "Buenos días" : "Buenas tardes";
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpGet]
		public ActionResult RsvpForm()
		{
			ViewBag.Message = "Your RSVP Form";

			return View();
		}

		[HttpPost]
		public ActionResult RsvpForm(RespuestaInvitados respuesta)
		{
			//TODO: Enviar un email al organizador de la fiesta

			if (ModelState.IsValid)
			{
				return View("Gracias", respuesta);
			}
			else { 
				return View();
			}
			

		}
	}
}