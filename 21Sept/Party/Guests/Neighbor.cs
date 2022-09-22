using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept
{
    public class Neighbor : IGuest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Glad { get; set; }


        public Neighbor(string name, int age, bool glad)
        {
            this.Name = name;
            this.Age = age;
            this.Glad = glad;
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
        public void Speech()
        {
            //kod
        }
    }
}
