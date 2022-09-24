using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept.Garderoben
{
    public class Shirt : Garment
    {
        public Shirt(string brand, string color, decimal price, string type)
        {
            this.Type = type;
            this.Color = color;
            this.Brand = brand;
            this.Price = price;
        }
    }
}
