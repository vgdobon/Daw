using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola Mundo");

            Animal leon = new Animal("Pepe", "Leon", "Crema", 10);

            Console.WriteLine(leon);

            Coche renault = new Coche("17898ABC", "Reanult", "Megane", 5, 180.5);

            Console.WriteLine(renault);

            Console.ReadLine();
        }
    }
}
