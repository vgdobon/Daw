using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public String Category { get; set; }
        public String SubCategory { get; set; }

        public double PriceCost { get; set; }

        public double PriceSell { get; set; }

        public Producto(int id, string name, string description, string category, string subCategory, double priceCost, double priceSell)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            SubCategory = subCategory;
            PriceCost = priceCost;
            PriceSell = priceSell;
        }

        public override String ToString()
        {
            return "{\nId:" + this.Id + "\nNombre" + this.Name + "\nDescripción: " + this.Description +
                "\nCategoría:" + this.Category + "\nSubcategoría: " + this.SubCategory + "\nPrecio costo" +
                this.PriceCost + "\nPrecio de venta: " + this.PriceSell;
        }

        public double CalcularBeneficio()
        {
            return this.PriceSell - this.PriceCost;
        }
    }
}
