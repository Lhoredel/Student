using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a capital letter (A–Z): ");
            char last = char.Parse(Console.ReadLine());

            for (char row = 'A'; row <= last; row++)
            {
                for (char ch = 'A'; ch <= row; ch++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }

        }
    }
}
