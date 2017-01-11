using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args) 
            {
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            string password = "Soundsharp";
            string input = string.Empty;

            Console.Write("Please enter the password:");
            input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine("Welkom to Soundsharp {0}", name);
            }
            else
            {
                Console.WriteLine("Password is wrong!");
            }
            Console.ReadLine();
        }
    }
}