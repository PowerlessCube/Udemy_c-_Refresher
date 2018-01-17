using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number:");
            var number1 = Console.ReadLine();

            Console.WriteLine("Second Number:");
            var number2 = Console.ReadLine();

            var n1 = Int32.Parse(number1);
            var n2 = Int32.Parse(number2);

            if (n1 < n2)
            {
                Console.WriteLine("Number 2 is bigger");
            }
            else if (n1 > n2)
            {
                Console.WriteLine("Number 1 is bigger");
            }
            else
            {
                Console.WriteLine("Yo dawg, dem numbers are the same");
            }
        }
    }
}
