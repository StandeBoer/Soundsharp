using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    struct MP3
        {
            public int ID;
            public string Merk;
            public string Model;
            public double Capaciteit;
            public double Prijs;
        }
    class GegevensMP3 {
       
        public static void NewMP3()
        {
            MP3 mp31;
            mp31.ID = 1;
            mp31.Merk = "GET technologies .inc";
            mp31.Model = "HF410";
            mp31.Capaciteit = 4096;
            mp31.Prijs = 129.95;

            Console.WriteLine("ID = {0}", mp31.ID);
            Console.WriteLine("Merk = {0}", mp31.Merk);
            Console.WriteLine("Model = {0}", mp31.Model);
            Console.WriteLine("Capaciteit = {0}", mp31.Capaciteit);
            Console.WriteLine("Prijs = {0}", mp31.Prijs);

        }
     }
}
