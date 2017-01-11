using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht11
{
    class login
    {
        public static void loginCode()
        {
            string password = "Soundsharp";
            string name = Console.ReadLine();
            Console.Write("Voer je password in: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Soundsharp":
                    Console.WriteLine("\nWelkom bij SoundSharp {0}.\n", name);
                    Hoofdmenu.ShowMenu();
                    break;
                default:
                    while (input != password)
                    {
                        int[] attempts = new int[2] { 1, 2 };
                        Console.WriteLine("Wachtwoord is fout! Nog {0} pogingen over!", attempts[1]);
                        string ww2 = Console.ReadLine();
                        if (ww2 == password)
                        {
                            Console.WriteLine("Welkom in Soundsharp {0}", name);
                            Hoofdmenu.ShowMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nog {0} poging over!", attempts[0]);
                            string ww3 = Console.ReadLine();
                            if (ww3 == password)
                            {
                                Console.WriteLine("Welkom in Soundsharp {0}", name);
                                Hoofdmenu.ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Game over!");
                                break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}