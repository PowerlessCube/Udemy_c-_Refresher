using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isValid
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if your number is between 1 and 10: ");
            string userNumber = Console.ReadLine();

            void isValid (string str)
            {
                var number = Int32.Parse(str);
                if ( (number >= 1) && (number <= 10))
                {
                    Console.WriteLine("the number: {0} is valid", number);
                }
                else
                {
                    Console.WriteLine("the number: {0} is out range (1-10)", number);
                }
            }
            
            isValid(userNumber);
        }
    }
}
