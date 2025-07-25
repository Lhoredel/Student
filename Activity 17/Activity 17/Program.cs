using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
            else
            {
            for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}");
                }
               
                
            }
        }
    }
}

