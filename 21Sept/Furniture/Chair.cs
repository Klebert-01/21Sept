using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept
{
    public class Chair : IFurniture
    {
        public string ItemType { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }


        public Chair(string color, decimal price, string brand)
        {
            ItemType = "Chair";
            this.Color = color;
            this.Price = price;
            this.Brand = brand;
        }

    }
}
