using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            Console.Write("Convert to (upper/lower): ");
            string choice = Console.ReadLine().ToLower();

            string result = "";

            foreach (char ch in input)
            {
                if (choice == "upper" && ch >= 'a' && ch <= 'z')
                    result += (char)(ch - 32);
                else if (choice == "lower" && ch >= 'A' && ch <= 'Z')
                    result += (char)(ch + 32);
                else
                    result += ch;
            }

            Console.WriteLine("Converted: " + result);
        }

    }
}

