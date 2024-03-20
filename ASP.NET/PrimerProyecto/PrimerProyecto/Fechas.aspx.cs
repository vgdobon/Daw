using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerProyecto
{
	public partial class Fechas : System.Web.UI.Page
	{
		public static DateTime Dt { get; set;}
		public static int DiasAdd { get; set; }

		public Fechas() {
			Dt = DateTime.Now;
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			Fechas.DiasAdd++;
			lblSalida.Text = Fechas.Dt.AddDays(DiasAdd).ToString();
        }

		protected void calcular_Click(object sender, EventArgs e)
		{
			

			SelectedDatesCollection fecha1 = Calendar1.SelectedDates;
			TimeSpan diferencia = fecha1[fecha1.Count-1] - fecha1[0];
			int difenciaPersonalizada = 0;

			Button btn = (Button)sender;

			if (btn.Text.Equals("Días"))
			{
				difenciaPersonalizada = diferencia.Days;
			} 
			
			if(btn.Text.Equals("Horas"))
			{
				difenciaPersonalizada = (int)diferencia.TotalHours;
			} 
			
			if (btn.Text.Equals("Minutos"))
			{
				difenciaPersonalizada = (int)diferencia.TotalMinutes;
			}
			
			if (btn.Text.Equals("Segundos"))
			{
				difenciaPersonalizada = (int)diferencia.TotalSeconds;
			} 
			
			if (btn.Text.Equals("Milisegundos"))
			{
				difenciaPersonalizada = (int)diferencia.TotalMilliseconds;
			}

			lblSalidaDiferencia.Text = difenciaPersonalizada.ToString() +" " + btn.Text.ToLower();
			

		}

		protected void Calendar2_SelectionChanged(object sender, EventArgs e)
		{
			if (Calendar1.SelectedDates.Count > 0
			    && Calendar2.SelectedDates.Count > 0
			    && Calendar1.SelectedDates[0] < Calendar2.SelectedDates[Calendar2.SelectedDates.Count - 1])
			{

				Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDates[0], Calendar2.SelectedDates[Calendar2.SelectedDates.Count - 1]);
				Calendar2.SelectedDates.SelectRange(Calendar1.SelectedDates[0], Calendar2.SelectedDates[Calendar2.SelectedDates.Count - 1]);

				Calendar1.SelectedDayStyle.BackColor =
					System.Drawing.Color.LightBlue;
				Calendar1.SelectedDayStyle.BorderWidth = 0;
				Calendar1.SelectedDayStyle.Font.Bold = true;
				Calendar1.SelectedDayStyle.Font.Size = FontUnit.Large;

				Calendar2.SelectedDayStyle.BackColor =
					System.Drawing.Color.LightBlue;
				Calendar2.SelectedDayStyle.BorderWidth = 0;
				Calendar2.SelectedDayStyle.Font.Underline = false;
				Calendar2.SelectedDayStyle.Font.Size = FontUnit.Large;
			}
		}
	}
}