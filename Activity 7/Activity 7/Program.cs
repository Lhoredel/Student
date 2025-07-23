using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                float result = num1 + num2;
                Console.WriteLine($"The result is = {result}");
            }
            else if (operation == "-")
            {
                float result = num1 - num2;
                Console.WriteLine($"The result is = {result}");
            }
            else if (operation == "*")
            {
                float result = num1 * num2;
                Console.WriteLine($"The result is = {result}");
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    float result = num1 / num2;
                    Console.WriteLine($"The result is = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation entered");
            }

        }

    }
}
