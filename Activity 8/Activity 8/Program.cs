
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a number digits onl");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int result = number + 10;
                Console.WriteLine($"Result after adding 10: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            
        }
    }
}
