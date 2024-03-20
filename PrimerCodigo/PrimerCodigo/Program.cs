using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerCodigo
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			Console.Write("Hello World!!");
			Console.WriteLine("WriteLine 1");
			Console.WriteLine("WriteLine 2");
			Console.Write("Write");

			Console.WriteLine("Dime un número");
			Double numero = Convert.ToDouble(Console.ReadLine());

			Double cuadrado =  Math.Pow(numero, 2 );
			Double cubo = Math.Pow(numero, 3);
			Double cuarta = Math.Pow(numero, 4);
			float valor = 87.5F;
			double valor1 = 87.4;
			int valorInt = 43243243;
			byte valorByte = (byte)valorInt;

			Console.WriteLine(numero + "^2=" + cuadrado +
							  "\n" + numero + "^3=" + cubo +
							  "\n" + numero + "^4=" + cuarta);

			Console.WriteLine(valorByte);

			Console.ReadLine();
		}
	}
}
