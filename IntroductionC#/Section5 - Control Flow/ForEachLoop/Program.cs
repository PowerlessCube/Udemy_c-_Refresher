using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // Same bu easier to understand
            foreach (var letter in name)
            {
                Console.WriteLine(letter);
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
