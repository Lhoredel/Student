using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature");
            float tempatureInCel = float.Parse(Console.ReadLine());

            if ((tempatureInCel >= -100 && tempatureInCel <= 100))
            {
                float fahrenheit = ((tempatureInCel * 9 / 5) + 32);
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Invalid Temparature");
            }

        }
    }
}
