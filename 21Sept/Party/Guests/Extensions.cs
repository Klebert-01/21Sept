using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sept.Party.Guests
{
    public static class Extensions
    {
        public static void EatCookies(this Guest guest)
        {
            Console.WriteLine("Eating the cookies");
        }
        public static void Smoking(this Guest guest)
        {
            Console.WriteLine("Puff puff");
        }
        public static void SittingDown(this Guest guest)
        {
            Console.WriteLine("Sitting down");
        }
    }
}

