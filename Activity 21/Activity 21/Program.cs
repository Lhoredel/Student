using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Greet");
                Console.WriteLine("2 - Show Current Date and Time");
                Console.WriteLine("3 - Exit");

               
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello, User!");
                            break;

                        case 2:
                            Console.WriteLine(DateTime.Now);
                            break;

                        case 3:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }


    }

