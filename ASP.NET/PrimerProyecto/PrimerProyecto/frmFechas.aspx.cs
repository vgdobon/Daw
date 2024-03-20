using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerProyecto
{
	public partial class frmFechas : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnDia_Click(object sender, EventArgs e)
		{
			int dia = Convert.ToInt32(txtDia.Text);
			int mes = Convert.ToInt32(txtMes.Text);
			int anio = Convert.ToInt32(txtAno.Text);

			DateTime fecha = new DateTime(anio, mes, dia);

			DayOfWeek diaSemana = fecha.DayOfWeek;
		
			int mesNumero = fecha.Month;

			switch (diaSemana)
			{
				case DayOfWeek.Monday:
					lblDiaSalida.Text = "Lunes";
					break;
				case DayOfWeek.Tuesday:
					lblDiaSalida.Text = "Martes";
					break;
				case DayOfWeek.Wednesday:
					lblDiaSalida.Text = "Miercoles";
					break;
				case DayOfWeek.Thursday:
					lblDiaSalida.Text = "Jueves";
					break;
				case DayOfWeek.Friday:
					lblDiaSalida.Text = "Viernes";
					break;
				case DayOfWeek.Saturday:
					lblDiaSalida.Text = "Sabado";
					break;
				case DayOfWeek.Sunday:
					lblDiaSalida.Text = "Domingo";
					break;
			}

			switch(mesNumero)
			{
				case 1:
					lblMesSalida.Text = "Enero";
					break;
				case 2:
					lblMesSalida.Text = "Febrero";
					break;
				case 3:
					lblMesSalida.Text = "Marzo";
					break;
				case 4:
					lblMesSalida.Text = "Abril";
					break;
				case 5:
					lblMesSalida.Text = "Mayo";
					break;
				case 6:
					lblMesSalida.Text = "Junio";
					break;
				case 7:
					lblMesSalida.Text = "Julio";
					break;
				case 8:
					lblMesSalida.Text = "Agosto";
					break;
				case 9:
					lblMesSalida.Text = "Septiembre";
					break;
				case 10:
					lblMesSalida.Text = "Octubre";
					break;
				case 11:
					lblMesSalida.Text = "Noviembre";
					break;
				case 12:
					lblMesSalida.Text = "Diciembre";
					break;
			}

			txtAno.Text = fecha.Year.ToString();

			DateTime fechaNavidad = new DateTime(2024, 12, 25);
			TimeSpan diasFaltantes = fechaNavidad - fecha;

			lblNavidad.Text = "Faltan " + diasFaltantes.Days + " dias para Navidad";


		}
	}
}