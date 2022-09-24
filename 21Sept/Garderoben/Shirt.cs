using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept.Garderoben
{
    public class Shirt : IGarment
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Shirt(string brand, string color, decimal price, string type)
        {
            this.Type = type;
            this.Color = color;
            this.Brand = brand;
            this.Price = price;
        }
    }
}
