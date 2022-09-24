using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept.Party.Furniture
{
    public class Furniture : IFurniture
    {
        public string ItemType { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
    }
}
