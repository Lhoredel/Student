using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter your age:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age) && age >= 1 && age <= 130)
            {
                if (age <= 12)
                {
                    Console.WriteLine("You are a child.");
                }
                else if (age <= 19)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else if (age <= 59)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior citizen.");
                }
                Console.WriteLine($"Your age is: {age}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age between 1 and 120.");
            }
        }
    }
}
   
