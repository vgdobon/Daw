using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    internal class Animal
    {
        public String Name { get; set; }
        public String Especie { get; set; }
        public String Color {  get; set; }
        public int Age {  get; set; }

        public Animal(string name, string especie, string color, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Especie = especie ?? throw new ArgumentNullException(nameof(especie));
            Color = color ?? throw new ArgumentNullException(nameof(color));
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Animal animal &&
                   Name == animal.Name &&
                   Especie == animal.Especie &&
                   Color == animal.Color &&
                   Age == animal.Age;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Name + "\nEspecie: " + this.Especie +
                "\nEdad: " + this.Age + "\nColor: " + this.Color;
        }


    }
}
