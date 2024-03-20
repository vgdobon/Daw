using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominas
{
    public class Empleado
    {

        public int id {  get; set; }

        private String Nss;

        private String Nombre { get; set; }

        public String Apellido { get; set; }

        private Double Sueldo ;

        public Empleado(string nss)
        {
            Nss = nss;
        }

        public Empleado(int id, string nss, string nombre, string apellido, double sueldo)
        {
            this.id = id;
            Nss = nss ?? throw new ArgumentNullException(nameof(nss));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Sueldo = sueldo;
        }

        public double GetSueldo()
        {
            return Sueldo;
        }

        public void SetSueldo(double sueldo)
        {
            if(sueldo < 400 || sueldo > 400)
            {
                this.Sueldo = 400;
            }
            else
            {
                this.Sueldo = sueldo;
            }
        }

        public String GetNss()
        {
            return Nss;
        }

        public void SetNss(String nss)
        {   
            this.Nss = nss;
        }

        public override string ToString()
        {
            return base.ToString() + Nombre + " " + Apellido + " con número de la seguridad social: " + Nss 
                + " tiene un sueldo de " + Sueldo + " \u20ac";
        }

    }
}
