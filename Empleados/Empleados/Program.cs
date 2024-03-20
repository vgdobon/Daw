using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmpleadoAsalariado manuel = new EmpleadoAsalariado("Manuel", "Pérez", "111-111",3000);
            //Empleado ana = new Empleado("Ana", "García", "222-222");

            Console.OutputEncoding = Encoding.Unicode;

            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("Jesús", "García", "333-333", 1500.50);

            Console.WriteLine(empleadoAsalariado);


            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras("Pepe", "Martinez", "222-222", 10, 10.5);

            Console.WriteLine(empleadoPorHoras);

            EmpleadoPorComisiones empleadoPorComisiones = new EmpleadoPorComisiones("Isabel", "Gutierrez", "444-444", 10450.50, 0.3);
            Console.WriteLine(empleadoPorComisiones);

            Console.ReadLine();
        }
    }
}
