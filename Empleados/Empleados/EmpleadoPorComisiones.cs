using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class EmpleadoPorComisiones : Empleado
    {
		private double ventasTotales;

        public double VentasTotales
		{
			get { return ventasTotales; }
			set { ventasTotales = value; }
		}

		private double porcentaje;

		public double Porcentaje
		{
			get { return porcentaje; }
			set { this.porcentaje = value < 0 || value > 0.5 ? 0 : value; }
		}


		public EmpleadoPorComisiones(string nombre, string apellido, string nss, double ventasTotales,double porcentaje) : base(nombre, apellido, nss)
        {

            this.VentasTotales = ventasTotales;
            Porcentaje = porcentaje;    
        }

        public override string ToString()
        {
            return base.ToString() + " se lleva un "+ Porcentaje*100 +"% de las ventas. Este mes ha llevado este mes "
                + Cobrar() + "\u20AC";
        }

        private double Cobrar()
        {
            return VentasTotales * Porcentaje;
        }

        public override double Retener()
        {
            return this.Cobrar() * 0.15;
        }
    }
}
