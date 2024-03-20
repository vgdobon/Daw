using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Empleado ana = new Empleado(0, "222-222", "Ana", "Casanova", 1800.50);

            Console.WriteLine(ana);

            Console.ReadLine();
        }
    }
}
