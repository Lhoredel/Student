using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                while (num == 0)
                {
                    Console.WriteLine("num");
                    num--;
                }
            }
            
            else
            
                Console.WriteLine("Input must be a positive integer");
        }
    }
}

