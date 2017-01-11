using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Opdracht8
{
    struct MP3
    {
        public int ID;
        public string Merk;
        public string Model;
        public double Capaciteit;
        public double Prijs;
        public int Voorraad;

        public int id
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.id = value;
            }
        }
        public string merk
        {
            get
            {
                return this.Merk;
            }
            set
            {
                this.Merk = value;
            }
        }
        public string model
        {
            get
            {
                return this.Model;
            }
            set
            {
                this.Model = value;
            }
        }
        public double capaciteit
        {
            get
            {
                return this.Capaciteit;
            }
            set
            {
                this.Capaciteit = value;
            }
        }
        public double prijs
        {
            get
            {
                return this.Prijs;
            }
            set
            {
                this.Prijs = value;
            }
        }
        public int voorraad
        {
            get
            {
                return this.Voorraad;
            }
            set
            {
                this.Voorraad = value;
            }
        }
    }

    class GegevensMP3
    {
        public static List<MP3> List;
        public static void Array()
        {
            List = new List<MP3>();
            List.Add(new MP3 { ID = 1, Merk = "GET technologies.inc", Model = "HF410", Capaciteit = 4096, Prijs = 129.95, Voorraad = 500});
            List.Add(new MP3 { ID = 2, Merk = "Far & Loud", Model = "XM 600", Capaciteit = 8192, Prijs = 224.95, Voorraad = 500});
            List.Add(new MP3 { ID = 3, Merk = "Innotivative", Model = "z3", Capaciteit = 512, Prijs = 79.95, Voorraad = 500});
            List.Add(new MP3 { ID = 4, Merk = "Resistance", Model = "3001", Capaciteit = 4096, Prijs = 124.95, Voorraad = 500});
            List.Add(new MP3 { ID = 5, Merk = "CBA", Model = "NXT volume", Capaciteit = 2048, Prijs = 159.05, Voorraad = 500});

            foreach (MP3 mp3 in List)
            {
                Console.WriteLine("ID= {0} Merk= {1} Model= {2} Capaciteit= {3} Prijs= {4}", mp3.id, mp3.merk, mp3.model, mp3.capaciteit, mp3.prijs);
            }

        }
    }
}
