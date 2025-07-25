using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correcrtPIN = "12345";   
            int attempts = 0;

            while (attempts < 3)
                {
                    Console.Write("Enter your PIN: ");
                    string pin = Console.ReadLine();
                  
                
                if (pin == correcrtPIN)
                    {
                        Console.WriteLine("Access granted.");
                        break;
                    }
                    else
                    {
                        attempts++;
                        if (attempts < 3)
                        {
                            Console.WriteLine($"Incorrect PIN. You have {3 - attempts} attempts left.");
                        }
                        else
                        {
                            Console.WriteLine("Access denied. Too many incorrect attempts.");
                        }
                    }
                }
            }
    }
}
