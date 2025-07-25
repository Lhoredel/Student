using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (0–999): ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0 || num > 999)
            {
                Console.WriteLine("Out of range.");
                return;
            }

            string words = "";

            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int units = num % 10;

            if (hundreds > 0)
            {
                words += GetWord(hundreds) + " Hundred ";
            }

            if (tens == 1)
            {
                words += GetTeens(num % 100);
            }
            else
            {
                if (tens > 1)
                    words += GetTens(tens) + " ";
                if (units > 0)
                    words += GetWord(units);
            }

            Console.WriteLine(words.Trim());
        }

        static string GetWord(int n)
        {
            switch (n)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "";
            }
        }

        static string GetTens(int n)
        {
            switch (n)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
                default: return "";
            }
        }

        static string GetTeens(int n)
        {
            switch (n)
            {
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: return "";
            }

        }
    }
}
