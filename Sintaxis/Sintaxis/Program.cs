using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");            
            MensajePantalla();
            SumaNumero(4, 5);



            Console.ReadLine();
            
        }
        static void MensajePantalla(){
                Console.WriteLine("Mensaje desde el método mensaje en pantalla");
        }

        static void SumaNumero(int num1, int num2) {
            
            Console.WriteLine($"La suma de los números es:  { num1 + num2} ");
        }

        private static int MultiplicaNumero(int num1,
                                            int num2,
                                            int num3=2) => num1 * num2;
    }
}
