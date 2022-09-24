using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept.Party.Guests
{
    public class Guest : IGuest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Glad { get; set; }

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
            if (Glad)
            {
            Console.WriteLine($"{Name} is dancing");
            }
            else
            {
                Console.WriteLine($"{Name} don't want to dance");
            }
        }
        public void GoToBalcony()
        {
            Console.WriteLine($"{Name} is on the balcony");
        }
        public void Drink()
        {
            Console.WriteLine($"{Name} is drinking");
        }
        public void Speech()
        {
            Console.WriteLine("Jag är ju ingen talare men..");
        }
    }
}
