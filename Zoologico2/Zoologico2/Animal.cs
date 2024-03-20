using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico2
{
    public class Animal
    {

        private static int NumAnimales;

        private String Nombre;

        public String Especie { get; set; }

        public String Color { get; set; }


        public static int getNumAnimales()
        {
            return NumAnimales;
        }

        private int edad;
        public int Edad { 
            get { return this.edad; }
            set
            {
                this.edad = value < 0 || value > 200 ? 0 : value; 
            }
        }

        public void ContarNuevoAnimal()
        {
            NumAnimales++;
        }

        public Boolean TieneHambre {  get; set; }

        public Animal(string nombre, string especie)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Especie = especie ?? throw new ArgumentNullException(nameof(especie));
            ContarNuevoAnimal();
        }

        public Animal(string nombre, string especie, string color, int edad, bool tieneHambre)
        {
            Nombre = nombre;
            Especie = especie;
            Color = color;
            this.Edad=edad;
            TieneHambre = tieneHambre;
            ContarNuevoAnimal();
        }

        public String GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public void Dormir(int horas)
        {
            Console.WriteLine("El/la " + Especie + " " + Nombre + " lleva durmiendo " + " " +  horas + " horas");
        }

        public String Comer(String comida)
        {
            return "El/la " + this.Especie + " " + this.Nombre + " está comiendo " + comida + ".";
        }
    }
}
