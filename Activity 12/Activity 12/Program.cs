using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");   
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
