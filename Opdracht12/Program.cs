using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht12
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "admin";
            const string ab = "1234";

            if (args.Length == 2)
            {
                if (args[0] == ad && args[1] == ab)
                {
                    Console.Clear();
                    Program.autologin();
                }
            }
            else
            {
                Console.Clear();
                login.loginCode();
                Console.ReadLine();
            }
        }

        public static void autologin()
        {
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Statistieken");
            Console.WriteLine("4. Toon menu");
            Console.WriteLine("5. Exit");

            ConsoleKeyInfo userinputput = new ConsoleKeyInfo();
            userinputput = Console.ReadKey();

            while (userinputput.KeyChar != '5')
            {
                switch (userinputput.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Overzicht mp3 spelers\n", userinputput.KeyChar);
                        Gegevenslijst.overzicht();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Overzicht voorraad\n", userinputput.KeyChar);
                        Gegevenslijst.showvoorraad();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Statistieken", userinputput.KeyChar);
                        Gegevenslijst.opd10();
                        break;
                    case '4':
                        Program.toonmenuadmin();
                        break;
                    default:
                        break;
                }
                userinputput = Console.ReadKey(true);
            }
        }

        public static void toonmenuadmin()
        {
            Console.Clear();
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Statistieken");
            Console.WriteLine("4. Toon menu");
            Console.WriteLine("5. Exit");
        }
    }
}