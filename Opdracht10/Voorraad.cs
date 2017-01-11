using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht10
{
    class voorraad
    {
        public static List<mp33> mylist2 = new List<mp33>()
            {
                new mp33() {id = 1, prijs = 129.95, voorraad = 500, capaciteit = 4096},
                new mp33() {id = 2, prijs = 224.95, voorraad = 500, capaciteit = 8192},
                new mp33() {id = 3, prijs = 79.95, voorraad = 500, capaciteit = 512},  
                new mp33() {id = 4, prijs = 124.95, voorraad = 500, capaciteit = 4096},
                new mp33() {id = 5, prijs = 159.05, voorraad = 500, capaciteit = 2048}
            };

        //Optie 8, toon menu
        public static void toonmenu()
        {
            Console.Clear();
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Muteer voorraad");
            Console.WriteLine("4. Statistieken");
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

        public static void opd10()
        {
            //Opdracht 10.1
            int V = mylist2.Sum(P => P.voorraad);
            Console.WriteLine("Het totaal aantal mp3-spelers wat in voorraad is: {0} stuks", V);

            //Opdracht 10.2
            double totwaarde = 0;
            foreach (mp33 som in mylist2)
            {
                totwaarde += som.prijs * som.voorraad;
            }
            Console.WriteLine("De totale waarde van de voorraad mp3 spelers: {0} euro", Math.Round(totwaarde, 0));

            //Opdracht 10.3
            double gemiddelde = totwaarde / V;
            Console.WriteLine("De gemiddelde prijs van een mp3 speler bij SoundSharp: {0} euro", Math.Round(gemiddelde, 2));

            //Opdracht 10.4
            Console.WriteLine("\nDe mp3 speler met de beste prijs per mB :");
            foreach (mp33 beste in mylist2)
            {
                double besteprijs = beste.prijs / beste.capaciteit;
                Console.WriteLine("Mp3 speler {0}: {1} euro per mB", beste.id, Math.Round(besteprijs, 2));
            }

            Console.WriteLine("\nTyp 8 in voor menu");
        }
    }
}