using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter your grade:");
            int grade = Convert.ToInt32( Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine($"Your grade is = A");
            }
            else if (grade >= 80 && grade <= 89){
                Console.WriteLine($"Your grade is = B");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine($"Your grade is = C");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine($"Your grade is = D");
            }
            else if (grade < 60 && grade >= 0)
            {
                Console.WriteLine($"Your grade is = F");
            }
            else 
            {
                Console.WriteLine($"Invalid Grade");
            }



        }
    }
}
