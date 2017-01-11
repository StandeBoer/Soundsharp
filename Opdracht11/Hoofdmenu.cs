using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht11
{
    class Hoofdmenu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Muteer voorraad");
            Console.WriteLine("4. Statistieken");
            Console.WriteLine("5. Toevoegen mp3 speler");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Toon menu");
            Console.WriteLine("9. Exit");

            ConsoleKeyInfo userinput = new ConsoleKeyInfo();
            userinput = Console.ReadKey();

            while (userinput.KeyChar != '9')
            {
                switch (userinput.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Overzicht mp3 spelers\n", userinput.KeyChar);
                        //oude optie >> Gegevensspelers.showmp3();
                        Gegevenslijst.overzichtzicht();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Overzicht voorraad\n", userinput.KeyChar);
                        Gegevenslijst.showvoorraad();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Muteer voorraad\n", userinput.KeyChar);
                        Gegevenslijst.muteren();
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Statistieken\n", userinput.KeyChar);
                        Gegevenslijst.opd10();
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("\rGekozen actie: {0}. Toevoegen mp3 speler\n", userinput.KeyChar);
                        Gegevenslijst.mp3toevoegen();
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        voorraad.toonmenu();
                        break;
                    default:
                        break;
                }
                userinput = Console.ReadKey(true);
            }
        }
    }
}