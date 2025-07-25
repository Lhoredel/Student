using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctUser = "admin";
            const string correctPass = "1234";

            while (true)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (username == correctUser && password == correctPass)
                {
                    Console.WriteLine("Login successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }

            }
        }
}
