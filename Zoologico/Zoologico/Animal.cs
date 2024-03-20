using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{

    public class Animal
    {
        private String Nombre { get; set; }

        private string Especie {  get; set; }

        private int Edad {  get; set; }

        private String Color {  get; set; }

        private Boolean Hambre {  get; set; }

        public Animal(string nombre, string especie, int edad, string color, bool hambre)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Color = color;
            Hambre = hambre;
        }

        public override string ToString()
        {
            return "{\n" + "Nombre: " + this.Nombre + ";\nEdad: "+ this.Edad + 
                    ";\nColor: " + this.Color + ";\nEspecie: " + this. Especie + ";\nTiene Hambre:"+ this.Hambre + "\n}";
        }

        public void Dormir(int horas)
        {
            Console.WriteLine("La " + this.Especie + " " + this.Nombre + " necesita dormir " + horas + " horas");
        }

        public string Dormir1(int horas)
        {
            return "La " + this.Especie + " " + this.Nombre + " necesita dormir " + horas + " horas.";
        }

        public void Comer(String comida)
        {
            Console.WriteLine("La " + this.Especie + " " + this.Nombre + " animal está comiendo " + comida + ".");
        }
    }
   
}
