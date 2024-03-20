using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRacional
{
    public class Calculadora
    {
        
        public static String Operar(String x, String y, String operador)
        {
            string[] fraccion1 = x.Split('/');
            string[] fraccion2 = y.Split('/');

            Racional op1 = new Racional(int.Parse(fraccion1[0]) , int.Parse(fraccion1[1]));
            Racional op2 = new Racional(int.Parse(fraccion2[0]), int.Parse(fraccion2[1]));

            Racional resultado;

            switch (operador)
            {
                case "+":
                 
                    resultado = Sumar(op1 , op2);  
                    break;

                case "-":
                    resultado = Restar(op1 , op2);
                    break;

                case "*":
                    resultado = Multiplicar(op1, op2);
                    break;

                case "/":
                    resultado = Dividir(op1,op2);
                    break;

                default:
                    resultado = new Racional(0, 0);
                    break;
            }

            return PintarSalida(op1,op2, resultado, operador);
    


        }

        public static String PintarSalida(Racional op1, Racional op2, Racional resultado,String operador)
        {
            resultado = resultado.SimplificarFraccion();
            String salida = op1.Numerador + "/" + op1.Denominador + " " + operador + " " + op2.Numerador + "/" + op2.Denominador + " = " + resultado.Numerador + "/"+ resultado.Denominador;
            return salida;
        }

        public static Racional Dividir(Racional op1, Racional op2)
        {
            int numeradorResultado = op1.Numerador * op2.Denominador;
            int denominadorResultado = op1.Denominador * op2.Numerador;
            return new Racional(numeradorResultado, denominadorResultado);
        }

        public static Racional Multiplicar(Racional op1, Racional op2)
        {
            int numeradorResultado = op1.Numerador * op2.Numerador;
            int denominadorResultado = op1.Denominador * op2.Denominador;
            return new Racional(numeradorResultado, denominadorResultado);
        }

        public static Racional Restar(Racional op1, Racional op2)
        {

            int numeradorResultado = (op1.Numerador * op2.Denominador) - (op2.Numerador * op1.Denominador);
            int denominadorResultado = op1.Denominador * op2.Denominador;
            return new Racional(numeradorResultado, denominadorResultado);
        }

        public static Racional Sumar(Racional op1, Racional op2)
        {

            int numeradorResultado = (op1.Numerador * op2.Denominador) + (op2.Numerador * op1.Denominador);
            int denominadorResultado = op1.Denominador * op2.Denominador;

            return new Racional( numeradorResultado,denominadorResultado );
        }

        public static Boolean IsEven( double numero)
        {
            return numero%2 == 0;

        }
        
        public static String IsEvenOrOdd(double numero)
        {
            if (IsEven(numero))
            {
                return "El número " + numero + " es par";
            }
            else
            {
                return "El número " + numero + " es impar";
            }
        }
    }
}
