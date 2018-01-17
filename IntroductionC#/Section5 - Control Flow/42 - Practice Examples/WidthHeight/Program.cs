using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidthHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Height:");
            var height = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Width:");
            var width = Int32.Parse(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Your picture is portrait");
            }
            else if (height < width)
            {
                Console.WriteLine("Your picture is landscape");
            }
            else
            {
                Console.WriteLine("Your picture is a square");
            }

        }
    }
}
