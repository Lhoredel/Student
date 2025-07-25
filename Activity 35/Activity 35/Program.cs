using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            string result = "";

            bool newWord = true;

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    result += ch;
                    newWord = true;
                }
                else if (newWord && ch >= 'a' && ch <= 'z')
                {
                    result += (char)(ch - 32); // uppercase first letter
                    newWord = false;
                }
                else if (!newWord && ch >= 'A' && ch <= 'Z')
                {
                    result += (char)(ch + 32); // lowercase rest
                }
                else
                {
                    result += ch;
                    newWord = false;
                }
            }

            Console.WriteLine("Formatted: " + result);
        }

    }
}

