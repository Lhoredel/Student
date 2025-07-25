using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pw = Console.ReadLine();
            bool valid = pw.Length >= 8 && pw.Any(char.IsDigit) && pw.Any(char.IsUpper);
            Console.WriteLine(valid ? "Valid password" : "Invalid password");


        }
    }
}
