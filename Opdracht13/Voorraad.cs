using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht13
{
    class voorraad
    {
        public static List<mp33> mylist2 = new List<mp33>()
            {
                new mp33() {id = 1, voorraad = 500},
                new mp33() {id = 2, voorraad = 500},
                new mp33() {id = 3, voorraad = 500},  
                new mp33() {id = 4, voorraad = 500},
                new mp33() {id = 5, voorraad = 500}
            };

        //case 8 toon menu
        public static void toonmenu()
        {
            Console.Clear();
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
        }
    }
}