using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.Write("Enter an index (starting from 0): ");
           
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index < word.Length)
                {
                    Console.WriteLine("Character at index " + index + " is: " + word[index]);
                }
                else
                {
                    Console.WriteLine("Index is out of range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
    }
}




    
   

