using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht13
{
    public class mp33
    {
        public int id;
        public string merk;
        public string model;
        public int capaciteit;
        public double prijs;
        public int voorraad;

        public mp33(int id1, string merk1, string model1, int capaciteit1, double prijs1, int voorraad1)
        {
            id = id1;
            merk = merk1;
            model = model1;
            capaciteit = capaciteit1;
            prijs = prijs1;
            voorraad = voorraad1;
        }

        public mp33() { }

        public mp33(int idd, int voorraad1)
        {
            id = idd;
            voorraad = voorraad1;
        }
    }

    class Gegevenslijst
    {
        public static List<mp33> mylist = new List<mp33>(){
                new mp33() {id = 1, merk = "GET technologies .inc", model = "HF 410", capaciteit = 4096, prijs = 129.95, voorraad = 500},
                new mp33() {id = 2, merk = "Far & Loud", model = "XM 600", capaciteit = 8192, prijs = 224.95, voorraad = 500},
                new mp33() {id = 3, merk = "Innotivative", model = "Z3", capaciteit = 512, prijs = 79.95, voorraad = 500},
                new mp33() {id = 4, merk = "Resistance S.A.", model = "3001", capaciteit = 4096, prijs = 124.95, voorraad = 500},
                new mp33() {id = 5, merk = "CBA", model = "NXT volume", capaciteit = 2048, prijs = 159.05, voorraad = 500}
             };

        //Overzicht mp3 spelers
        public static void overzicht()
        {
            foreach (mp33 A in mylist)
            {
                Console.WriteLine("mp3 speler {0}:\n", A.id);
                Console.WriteLine("Merk: \t\t\t{0}", A.merk);
                Console.WriteLine("Model: \t\t\t{0}", A.model);
                Console.WriteLine("Opslagcapaciteit: \t{0} MB", A.capaciteit);
                Console.WriteLine("Prijs: \t\t\t{0}\n", A.prijs);
            }
            Console.WriteLine("Typ 8 in voor menu");
        }

        //toon voorraad
        public static void showvoorraad()
        {
            foreach (mp33 AA in mylist)
            {
                Console.WriteLine("mp3 speler {0}:", AA.id);
                Console.WriteLine("Voorraad: {0}\n", AA.voorraad);
            }
            Console.WriteLine("Typ 8 in voor menu");
        }

        //mutatie in de voorraad aanbrengen
        public static void muteren()
        {
            try
            {
                Console.Write("Voer een ID in van een mp3 speler: ");
                int A = int.Parse(Console.ReadLine());
                foreach (mp33 Q in mylist)
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

        //Opdracht 10
        public static void opd10()
        {
            //Opdracht 10.1
            int voorraad = mylist.Sum(item => item.voorraad);
            Console.WriteLine("Het totaal aantal mp3-spelers wat in voorraad is: {0} stuks", voorraad);

            //Opdracht 10.2
            double totaalwaarde; 
            totaalwaarde = mylist.Sum(item => item.prijs * item.voorraad);
            Console.WriteLine("De totale waarde van de voorraad mp3 spelers: {0} euro", totaalwaarde);

            //Opdracht 10.3 
            double gemiddelde;
            gemiddelde = Math.Round(mylist.Average(item => item.prijs), 2);
            Console.WriteLine("De gemiddelde prijs van een mp3 speler: {0} euro", gemiddelde);

            //Opdracht 10.4
            mp33 beste = mylist.OrderBy(x => x.prijs / x.capaciteit).FirstOrDefault();
            Console.WriteLine("Mp3 speler met de beste prijs per mB:\t{0}", beste.model);

            Console.WriteLine("\nTyp 8 in voor menu");
        }

        //Toevoegen mp3 speler

        public static void mp3toevoegen()
        {
            try
            {
                var W = mylist.Count;
                int identiteit = W + 1;

                Console.Write("\nMerk van de mp3 speler: ");
                string merktoevoegen = Console.ReadLine();

                Console.Write("\nModel van de mp3 speler: ");
                string modeltoevoegen = Console.ReadLine();

                Console.Write("\nOpslagcapaciteit van de mp3 speler: ");
                int captoevoegen = int.Parse(Console.ReadLine());

                Console.Write("\nPrijs van de mp3 speler: ");
                double prijstoevoegen = double.Parse(Console.ReadLine());

                mylist.Add(new mp33() { id = identiteit, merk = merktoevoegen, model = modeltoevoegen, capaciteit = captoevoegen, prijs = prijstoevoegen });
            }
            catch (FormatException e)
            {
                Console.WriteLine("Voer alleen een nummer in. Error bericht: {0}\n", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een error: {0}\n", e.Message);
            }
            Console.WriteLine("\nTyp 8 in voor menu of typ 5 in voor een nieuwe actie.");
        }
    }
}