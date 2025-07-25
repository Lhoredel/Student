using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_16
{

    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Enter the first number:");
                string num1Str = Console.ReadLine();
                Console.WriteLine("Enter the second number:");
                string num2Str = Console.ReadLine();
                Console.WriteLine("Enter operator (+,-,*,/):");
                string op = Console.ReadLine();

 
                if (float.TryParse(num1Str, out float num1) && float.TryParse(num2Str, out float num2))
                {
                    switch (op)
                    {
                        case "+":
                            Console.WriteLine($"Result: {num1 + num2}");
                            break;

                        case "-":
                            Console.WriteLine($"Result: {num1 - num2}");
                            break;

                        case "*":
                            Console.WriteLine($"Result: {num1 * num2}");
                            break;

                        case "/":
                            if (num2 != 0)
                            {
                                Console.WriteLine($"Result: {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Cannot divide by zero.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid operator.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                }
        }
    }
 }








