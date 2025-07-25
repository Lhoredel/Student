using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine($"Enter your numeric grade (0 - 100) :");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {

                if (grade >= 90)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Grad: F");
                }
                else if (grade >= 0)
                {
                    Console.WriteLine("Grade: F");
                }
                else
                {
                    Console.WriteLine("Invalid grade entered. Please enter a number between 0 and 100.");
                }
            }

        }
    }
}
