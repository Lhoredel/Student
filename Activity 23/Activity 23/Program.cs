using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int uppercaseCount = 0;

            foreach (char ch in sentence)
            {
                if (char.IsUpper(ch))
                    uppercaseCount++;
            }

            Console.WriteLine("Uppercase letters: " + uppercaseCount);
        }

    }
}

