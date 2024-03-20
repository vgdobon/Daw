using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class EmpleadoAsalariado : Empleado
    {

        private double sueldo;

       

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }


         public EmpleadoAsalariado(string nombre, string apellido, string nss,double sueldo) : base(nombre, apellido, nss)
         {
            this.Sueldo = sueldo;
         }


        public override double Cobrar()
        {
            return this.Sueldo;
        }

        public override String ToString()
        {
            return base.ToString() + " tiene un sueldo de " + this.Sueldo;
        }

        public override double Retener()
        {
            return this.Cobrar() * 0.15;
        }

      
    }
}
