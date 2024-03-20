using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Cuidador
    {
        private string Nombre {  get; set; }

        private String Apellido { get; set; }

        private double Salario { get; set; }

        private Boolean Fijo {  get; set; }


        public Cuidador(string nombre, string apellido, double salario, bool fijo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Salario = salario;
            Fijo = fijo;
        }

        public override string ToString()
        {
            String isFijo="No";

            if(Fijo)
            {
                isFijo = "Si";
            }
            return "{\n" + "Nombre: " + Nombre + ";\nApellido: " + Apellido +
                    ";\nSalario: " + Salario + " €/hora;\nFijo: " + isFijo + "\n}";
        }

        public string CobrarAlMes(int horas)
        {
            double salarioFinal = horas * this.Salario;

            return this.Nombre + " tiene un salario de: " + salarioFinal + " euros.";
        }
    }
}
