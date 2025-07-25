using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
        }

    }
}

