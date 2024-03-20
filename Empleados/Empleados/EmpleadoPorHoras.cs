using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class EmpleadoPorHoras : Empleado
    {
        private int horas;

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        private double sueldoHora;

        public double SueldoHora
        {
            get { return sueldoHora; }
            set { sueldoHora = value; }
        }

        public EmpleadoPorHoras(string nombre, string apellido, string nss,int horas, double sueldoHora) : base(nombre, apellido, nss)
        {
            this.Horas = horas;
            this.SueldoHora = sueldoHora;
        }

        public override string ToString()
        {
            return base.ToString() + " ha trabajado "+ Horas + " horas y tiene un sueldo por horas de "
                + SueldoHora + " y ha cobrado por ello "+ Cobrar() + " \u20AC";
        }

        public double Cobrar()
        {
            return sueldoHora * Horas;
        }

        public override double Retener()
        {
            return this.Cobrar() * 0.15;
        }
    }
}
