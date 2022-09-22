using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept
{
    public class Friend : IGuest
    {
        public string Name { get; set; }

        public Friend(string name)
        {
            this.Name = name;
        }
        public void Talk()
        {
            Console.WriteLine($"{Name} is talking to another guest");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating some snacks");
        }
        public void Dance()
        {
            Console.WriteLine($"{Name} is dancing");
        }
        public void GoToBalcony()
        {
            Console.WriteLine($"{Name} is on the balcony");
        }
        public void Drink()
        {
            Console.WriteLine($"{Name} is drinking");
        }
    }
}
