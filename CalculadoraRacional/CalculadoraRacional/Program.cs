using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero para la comprobación");

            Console.WriteLine(Calculadora.IsEvenOrOdd(Double.Parse(Console.ReadLine())));

            Console.WriteLine("Dime la primera fracción: (Ejemplo: 1/2)");

            String fraccion1 = Console.ReadLine();

            Console.WriteLine("Dime la operación:");

            String operador = Console.ReadLine();

            Console.WriteLine("Dime la segunda fracción: (Ejemplo: 1/2)");

            String fraccion2 = Console.ReadLine();

            Console.WriteLine(Calculadora.Operar(fraccion1, fraccion2, operador));

  

            Console.ReadLine();
        }
    }
}
