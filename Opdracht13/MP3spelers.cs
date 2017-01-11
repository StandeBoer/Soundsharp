using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht13
{
    public struct mp3
    {
        public int id;
        public string merk;
        public string model;
        public int capaciteit;
        public double prijs;

        public mp3(int id1, string merk1, string model1, int capaciteit1, double prijs1)
        {
            id = id1;
            merk = merk1;
            model = model1;
            capaciteit = capaciteit1;
            prijs = prijs1;
        }
    };

    class Mp3spelers
    {
        public static void showmp3()
        {
            List<int> id = new List<int>();
            id.Add(1);
            id.Add(2);
            id.Add(3);
            id.Add(4);
            id.Add(5);
            List<string> merk = new List<string>();
            merk.Add("GET technologies .inc");
            merk.Add("Far & Loud");
            merk.Add("Innotivative");
            merk.Add("Resistance S.A.");
            merk.Add("CBA");
            List<string> model = new List<string>();
            model.Add("HF 410");
            model.Add("XM 600");
            model.Add("Z3");
            model.Add("3001");
            model.Add("NXT volume");
            List<int> capaciteit = new List<int>();
            capaciteit.Add(4096);
            capaciteit.Add(8192);
            capaciteit.Add(512);
            capaciteit.Add(4096);
            capaciteit.Add(2048);
            List<double> prijs = new List<double>();
            prijs.Add(129.95);
            prijs.Add(224.95);
            prijs.Add(79.95);
            prijs.Add(124.95);
            prijs.Add(159.05);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("mp3 speler {0}:\n", id[i]);
                Console.WriteLine("Merk: \t\t\t{0}", merk[i]);
                Console.WriteLine("Model: \t\t\t{0}", model[i]);
                Console.WriteLine("Capaciteit: \t{0} MB", capaciteit[i]);
                Console.WriteLine("Prijs: \t\t\t{0}\n", prijs[i]);
            }
            Console.WriteLine("Typ 8 in voor menu");
        }
    }
}