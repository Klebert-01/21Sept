using _21Sept.Party.Furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept
{
    public class Lamp : Furniture
    {

        public Lamp(string color, decimal price, string brand)
        {
            ItemType = "Lamp";
            this.Color = color;
            this.Price = price;
            this.Brand = brand;
        }
    }
}
