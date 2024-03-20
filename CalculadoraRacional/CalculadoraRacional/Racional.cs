using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRacional
{
    public class Racional
    {
        public int Numerador {  get; set; }
        public int Denominador { get; set; }
        public Racional(int numerador, int denominador) {
            
            this.Numerador = numerador;
            this.Denominador = denominador;

        }

        public Racional SimplificarFraccion( )
        {
            int gcd = CalcularMCD(Numerador, Denominador);

            Numerador /= gcd;
            Denominador /= gcd;

            return this;
        }

        static int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
