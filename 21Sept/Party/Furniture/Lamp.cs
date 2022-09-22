using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept
{
    public class Lamp : IFurniture
    {
        public string ItemType { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }

        public Lamp(string color, decimal price, string brand)
        {
            ItemType = "Lamp";
            this.Color = color;
            this.Price = price;
            this.Brand = brand;
        }
    }
}
