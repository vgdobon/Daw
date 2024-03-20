using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal("Juancho", "Burro", 10, "Marron", true);


            Console.WriteLine(animal);

            Animal marcerlina = new Animal("Marcelina", "Tocina", 5, "Rosa", false);

            Console.WriteLine(marcerlina);
            

            Cuidador cui1 = new Cuidador("Marta", "Casas", 28, true);
            Cuidador cui2 = new Cuidador("Roberto", "Sanz", 17, false);

            Console.WriteLine(cui1);
            Console.WriteLine(cui2);

            marcerlina.Dormir(5);
            Console.WriteLine(marcerlina.Dormir1(5));
            marcerlina.Comer("pienso");

            Console.WriteLine(cui2.CobrarAlMes(160));
            Console.ReadLine();
        }
    }
}
