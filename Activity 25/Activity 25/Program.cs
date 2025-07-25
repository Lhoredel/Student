using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            while (true)
            {
                Console.Write("Enter a number (or type 'stop'): ");
                string input = Console.ReadLine();

                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
                    break;

                if (int.TryParse(input, out int num))
                    total += num;
                else
                    Console.WriteLine("Invalid input. Not a number.");
            }

            Console.WriteLine("Total sum: " + total);
        }

    }
}

