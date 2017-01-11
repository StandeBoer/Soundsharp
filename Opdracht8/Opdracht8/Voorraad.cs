using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8
{
    class Voorraadoverzicht
    {
        public static List<MP3> List;
        public static void voorraad()
        {
            List = new List<MP3>();
            List.Add(new MP3 { ID = 1, Voorraad = 500});
            List.Add(new MP3 { ID = 2, Voorraad = 500});
            List.Add(new MP3 { ID = 3, Voorraad = 500});
            List.Add(new MP3 { ID = 4, Voorraad = 500});
            List.Add(new MP3 { ID = 5, Voorraad = 500});

            Console.Clear();
            foreach (MP3 mp3 in List)
            {
                Console.WriteLine("ID= {0} Voorraad= {1}", mp3.id, mp3.voorraad);
            }
            Console.WriteLine("\nType 8 om terug te keren naar het hoofdmenu");
            string input = Console.ReadLine();
            switch (input)
            {
                case "8":
                    Hoofdmenu.ShowMenu();
                    break;

                default:
                    Voorraadoverzicht.voorraad();
                    break;
            }
        }
    }
}
