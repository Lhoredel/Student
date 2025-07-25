using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            while (number > 9)
            {
                int sum = 0;
                int temp = number;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                number = sum;
            }

            Console.WriteLine("Digital root: " + number);
        }

    }
}

