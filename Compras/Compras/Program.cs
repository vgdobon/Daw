using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Producto camara = new Producto(1, "Cámara de fotos", "Cámara de última generación que hace fotos en QHD"
                , "Electrónica", "Fotografía", 209.5, 300);

            Console.WriteLine(camara);
            Console.WriteLine(camara.CalcularBeneficio());
            Console.ReadLine();
        }
    }
}
