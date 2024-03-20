using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrimeraApp
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Coche
    {
        private String Matricula {  get; set; }
        private String Marca {  get; set; }

        private String Modelo {  get; set; }

        private int nPuertas { get; set; }
        private double VelocidadMax { get; set; }

        public Coche(string matricula, string marca, string modelo, int nPuertas, double velocidadMax)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            this.nPuertas = nPuertas;
            VelocidadMax = velocidadMax;
        }

        public override bool Equals(object obj)
        {
            return obj is Coche coche &&
                   Matricula == coche.Matricula &&
                   Marca == coche.Marca &&
                   Modelo == coche.Modelo &&
                   nPuertas == coche.nPuertas &&
                   VelocidadMax == coche.VelocidadMax;
        }

        public override int GetHashCode()
        {
            int hashCode = -1502783748;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Matricula);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Marca);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Modelo);
            hashCode = hashCode * -1521134295 + nPuertas.GetHashCode();
            hashCode = hashCode * -1521134295 + VelocidadMax.GetHashCode();
            return hashCode;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        public override string ToString()
        {

            return 
                "Nuevo Coche{" + "\nMatrícula:" + this.Matricula + "\nMarca: " + this.Marca +
                    "\nModelo: " + this.Modelo + "\nNúmero de puertas: " + this.nPuertas +
                    "\nVelocidad Máxima: " + this.VelocidadMax + "\n}";
        }
    }
}
