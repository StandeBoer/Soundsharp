using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht10
{
    class Hoofdmenu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("* MENU *");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Muteer voorraad");
            Console.WriteLine("4. Statistieken");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Toon menu");
            Console.WriteLine("9. Exit");

            ConsoleKeyInfo userinput = new ConsoleKeyInfo();
            userinput = Console.ReadKey();
            const int maxMenuItems = 9;

            while (userinput.KeyChar != '9')
            {
                switch (userinput.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Overzicht mp3 spelers\n", userinput.KeyChar);
                        Gegevenslist.overzicht();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Overzicht voorraad\n", userinput.KeyChar);
                        voorraad.showvoorraad();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Muteer voorraad\n", userinput.KeyChar);
                        voorraad.muteren();
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Statistieken\n", userinput.KeyChar);
                        voorraad.opd10();
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        voorraad.toonmenu();
                        break;
                    default:
                        if (userinput.KeyChar != maxMenuItems)
                        {
                            ErrorMessage();
                        }
                        break;
                }
                userinput = Console.ReadKey(true);
            }

        }
        private static void ErrorMessage()
        {
            Console.WriteLine("Error, invoer mag alleen van 1 tot en met 9 zijn.");
        }
    }
}