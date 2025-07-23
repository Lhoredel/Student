using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter an integer :");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number)) {

                if (number % 2 == 0) {
                    Console.WriteLine($"The number is even");
                }
                else
                {
                    Console.WriteLine($"The number is odd");
                }
            }
            else {
                Console.WriteLine("Invalid integer");
            }

        }
    }
}
