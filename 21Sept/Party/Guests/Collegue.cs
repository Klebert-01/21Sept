using _21Sept.Party.Guests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept
{
    public class Collegue : Guest
    {

        public Collegue(string name, int age, bool glad)
        {
            this.Name = name;
            this.Age = age;
            this.Glad = glad;
        }

    }
}
