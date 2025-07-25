using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int maxLength = 0, currentLength = 0;
            foreach (char c in sentence)
            {
                if (c != ' ')
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                        maxLength = currentLength;
                    currentLength = 0;
                }
            }
            if (currentLength > maxLength)
                maxLength = currentLength;

            Console.WriteLine("Longest word length: " + maxLength);
        }

    }
}

