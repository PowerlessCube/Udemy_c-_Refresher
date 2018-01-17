using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesCSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++; // a will be 10.
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // b is a like a copy of a.  The two variables are independant of each other in memory.

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0; // array1 first value becomes 0 too.  They point to the same object in the memory, hence the name reference types.
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
