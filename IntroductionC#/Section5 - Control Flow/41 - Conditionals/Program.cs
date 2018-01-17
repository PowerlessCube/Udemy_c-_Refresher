using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            int hour = 13;
            // one line of code you don't need to put them in code blocks {}
            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's evening");
            else
                Console.WriteLine("It's evening");

            // Turnery example.
            bool isGoldCustomer = false;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            // Switch Case
            var season = Season.Summer;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter. Brrr");
                    break;
                default:
                    Console.WriteLine("It's probably spring");
                    break;
            }
            // similar bit of code we can do the following
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter. Brrr");
                    break;
                default:
                    Console.WriteLine("It's probably spring");
                    break;
            }
        }
    }
}
