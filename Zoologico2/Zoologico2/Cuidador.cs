using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico2
{
    public class Cuidador
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public double SueldoHora;

        public Boolean Fijo { get; set; }

        public Cuidador(string nombre, string apellido, double sueldoHora, bool fijo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.SueldoHora = sueldoHora;
            Fijo = fijo;
        }

        public double GetSueldoHora()
        {
            return this.SueldoHora;
        }

        public void SetSueldoHora(double sueldoHora)
        {
            this.SueldoHora = sueldoHora;
        }

        public override String ToString()
        {
            return Nombre + " " + Apellido + " cobra " + SueldoHora + " euros/hora";
        }

        public double Cobrar(int horasTrabajadas)
        {
            return horasTrabajadas * SueldoHora;
        }

        public String DarComida ( string comida, Animal animal)
        {
            return this.Nombre + " le está dando " + comida + " al " + animal.Especie + " " + animal.GetNombre();
        }
    }
}
