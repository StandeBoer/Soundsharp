using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht9
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

        //Optie 8, toon menu
        public static void toonmenu()
        {
            Console.Clear();
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Muteer voorraad");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Toon menu");
            Console.WriteLine("9. Exit");
        }

        public static void showvoorraad()
        {

            foreach (mp33 AA in mylist2)
            {
                Console.WriteLine("mp3 speler {0}:", AA.id);
                Console.WriteLine("Voorraad: {0}\n", AA.voorraad);
            }
            Console.WriteLine("Typ 8 in voor menu");
        }

        public static void muteren()
        {

            try
            {

                Console.Write("Voer een ID in van een mp3 speler: ");
                int A = int.Parse(Console.ReadLine());
                foreach (mp33 Q in mylist2)
                {
                    if (A == Q.id)
                    {
                        Console.WriteLine("Huidige voorraad: {0}\n", Q.voorraad);
                        Console.Write("Mutatie voorraad: ");
                        int B = int.Parse(Console.ReadLine());
                        Q.voorraad = B + Q.voorraad;
                        if (Q.voorraad < 0)
                        {
                            Q.voorraad = Q.voorraad - B;
                            Console.WriteLine("\nMutatie niet uitgevoerd: voorraad mag niet negatief worden.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nNieuwe voorraad: {0}\n", Q.voorraad);
                        }
                    }
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine("Please enter a number. Error message: {0}\n", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("There is an error: {0}\n", e.Message);
            }
            Console.WriteLine("Typ 8 in voor menu of typ 3 in voor een nieuwe mutatie.");
        }
    }
}