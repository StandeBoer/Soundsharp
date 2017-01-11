using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
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
                            Console.WriteLine("// code voor case 1");
                            break;
                        case 2:
                            Console.WriteLine("// code voor case 2");
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
            Console.WriteLine(" 9. Exit program");
            Console.WriteLine("Make your choice: type 1, 2,... or {0} for exit", maxitems);
        }
        private static void ErrorMessage()
        {
            Console.WriteLine("Error, invoer mag alleen van 1 tot en met 9 zijn.");
        }
    }
}
