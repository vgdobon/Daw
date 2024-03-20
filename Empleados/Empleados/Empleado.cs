using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public abstract class Empleado
    {

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public String Nss {  get; set; }

        private int edad;
        public int Edad { get { return this.edad; } set
            {
                this.edad = value < 0 || value > 30 ? 0 : value;
            }
        }

        public abstract double Cobrar();

        public abstract double Retener();

        public Empleado(string nombre, string apellido, string nss)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Nss = nss ?? throw new ArgumentNullException(nameof(nss));
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido + " con número " + Nss ;
        }
    }
}
