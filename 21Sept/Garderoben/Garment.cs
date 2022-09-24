using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept.Garderoben
{
    public abstract class Garment : IGarment
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
