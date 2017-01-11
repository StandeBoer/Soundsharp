using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    struct MP3
    {
        public int ID;
        public string Merk;
        public string Model;
        public double Capaciteit;
        public double Prijs;
    }

    class GegevensMP3
    {
        public static void NewMP3()
        {
            MP3[] array = 
                new MP3[]{
                    new MP3() {ID = 1, Merk = "GET technologies .inc", Model = "HF410", Capaciteit = 4096, Prijs = 129.95},
                    new MP3() {ID = 2, Merk = "Far & Loud", Model = "XM 600", Capaciteit = 8192, Prijs = 224.95},
                    new MP3() {ID = 3, Merk = "Innotivative", Model = "z3", Capaciteit = 512, Prijs = 79.95},
                    new MP3() {ID = 4, Merk = "Resistance", Model = "3001", Capaciteit = 4096, Prijs = 124.95},
                    new MP3() {ID = 5, Merk = "CBA", Model = "NXT volume", Capaciteit = 2048, Prijs = 159.05}
            };

             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine("\nID = {0}", array[i].ID);
                 Console.WriteLine("Merk = {0}", array[i].Merk);
                 Console.WriteLine("Model = {0}", array[i].Model);
                 Console.WriteLine("Capaciteit = {0}", array[i].Capaciteit);
                 Console.WriteLine("Prijs = {0}", array[i].Prijs);
             }
        }
    }
}
