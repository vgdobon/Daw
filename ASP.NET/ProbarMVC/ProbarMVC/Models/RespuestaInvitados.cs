using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProbarMVC.Models
{
	public class RespuestaInvitados
	{
		[Required(ErrorMessage = "Tienes que indicar tu nombre")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "Pon tu correo electrónico")]
		[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Ese email no es válido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Pon tu teléfono")]
		public string Phone { get; set; }
		
		[Required(ErrorMessage = "Por favor, dinos si vendrás o no")]
		public bool? Confirmacion_Asistencia { get; set; }
	}
}