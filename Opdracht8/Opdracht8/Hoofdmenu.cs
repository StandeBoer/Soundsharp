using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8
{
    class Hoofdmenu
    {
        public static void ShowMenu()
        {
            const int maxMenuItems = 9;
            int selector = 0;
            bool correct = false;
            while (selector != maxMenuItems)
            {
                Console.Clear();
                Menu(maxMenuItems);
                correct = int.TryParse(Console.ReadLine(), out selector);
                if (correct)
                {
                    switch (selector)
                    {
                        case 1:
                            GegevensMP3.Array();
                            break;
                        case 2:
                            Voorraadoverzicht.voorraad();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            if (selector != maxMenuItems)
                            {
                                ErrorMessage();
                            }
                            break;
                    }
                }
                else
                {
                    ErrorMessage();
                }
                Console.ReadKey();
            }
        }
        private static void Menu(int maxitems)
        {
            Console.WriteLine(" 1. Overzicht MP3 spelers");
            Console.WriteLine(" 2. Overzicht MP3 voorraad");
            Console.WriteLine(" 8. Menu");
            Console.WriteLine(" 9. Exit");
            Console.WriteLine("Maak jouw keuze: type 1, 2,... of {0} voor exit", maxitems);
        }
        private static void ErrorMessage()
        {
            Console.WriteLine("Error, invoer mag alleen van 1 tot en met 9 zijn.");
        }

    }
}
