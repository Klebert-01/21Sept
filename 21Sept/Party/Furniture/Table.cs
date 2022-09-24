using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21Sept.Party.Furniture;

namespace _21Sept.Party.Furniture
{
    public class Table : Furniture
    {
        public Table(string color, decimal price, string brand)
        {
            ItemType = "Table";
            this.Color = color;
            this.Price = price;
            this.Brand = brand;
        }
    }

}
