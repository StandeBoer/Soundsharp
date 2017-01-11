using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Welcome to Soundsharp {0}", name);
            Console.ReadLine();
        }
    }
}
