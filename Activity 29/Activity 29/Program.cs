using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            if (start >= end)
            {
                Console.WriteLine("Invalid range.");
                return;
            }

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;
                if (num < 2) isPrime = false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                    Console.WriteLine(num);
            }

        }
    }
}
