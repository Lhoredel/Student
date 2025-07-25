using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Activity_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) && IsAlletter(name))
            {
                string formatted = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                Console.WriteLine($"Formatted name:" + formatted);
            }
            else
                Console.WriteLine("Invalid input");
        }

        private static bool IsAlletter(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
