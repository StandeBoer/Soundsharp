using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht9
{
    public class mp33
    {
        public int id;
        public string merk;
        public string model;
        public int capaciteit;
        public double prijs;
        public int voorraad;

        public mp33(int ID, string MERK, string MODEL, int CAPACITEIT, double PRIJS)
        {
            id = ID;
            merk = MERK;
            model = MODEL;
            capaciteit = CAPACITEIT;
            prijs = PRIJS;
        }

        public mp33() { }

        public mp33(int idd, int voorraad1)
        {
            id = idd;
            voorraad = voorraad1;
        }
    }

    class Gegevenslist
    {
        public static void overzicht()
        {
            List<mp33> mylist = new List<mp33>();
            mylist.Add(new mp33() { id = 1, merk = "GET technologies .inc", model = "HF 410", capaciteit = 4096, prijs = 129.95 });
            mylist.Add(new mp33() { id = 2, merk = "Far & Loud", model = "XM 600", capaciteit = 8192, prijs = 224.95 });
            mylist.Add(new mp33() { id = 3, merk = "Innotivative", model = "Z3", capaciteit = 512, prijs = 79.95 });
            mylist.Add(new mp33() { id = 4, merk = "Resistance S.A.", model = "3001", capaciteit = 4096, prijs = 124.95 });
            mylist.Add(new mp33() { id = 5, merk = "CBA", model = "NXT volume", capaciteit = 2048, prijs = 159.05 });


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
    }
}