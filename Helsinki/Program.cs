using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki
{
    class Program
    {
        struct Olimpia
        {
            public int helyezes, fo;
            public string sportag, versenyszam;
        }
        static void Main(string[] args)
        {
            List<Olimpia> pontszerzok = new List<Olimpia>();
            StreamReader olvaso = new StreamReader("helsinki.txt");
            while (!olvaso.EndOfStream)
            {
                string[] egysor = olvaso.ReadLine().Split(' ');
                Olimpia seged = new Olimpia();
                seged.helyezes = int.Parse(egysor[0]);
                seged.fo = int.Parse(egysor[1]);
                seged.sportag = egysor[2];
                seged.versenyszam = egysor[3];
                pontszerzok.Add(seged);

            }
            olvaso.Close();
            //foreach (var item in pontszerzok)
            //   Console.WriteLine(item.helyezes+"\t"+item.fo+"\t"+item.sportag+"\t"+item.versenyszam);
            Console.WriteLine("3. feladat:");
            Console.WriteLine("Az olimpián {0} pontszerző vett részt.", pontszerzok.Count());
            Console.WriteLine();
            Console.WriteLine("4. feladat:");

            int arany = 0;
            int ezust = 0;
            int bronz = 0;
            foreach (var item in pontszerzok)
            {
                if (item.helyezes == 1) arany++;
                if (item.helyezes == 2) ezust++;
                if (item.helyezes == 3) bronz++;

            }
            Console.WriteLine("Arany: {0}", arany);
            Console.WriteLine("Ezüst: {0}", ezust);
            Console.WriteLine("Bronz: {0}", bronz);
            Console.WriteLine("Összesen: {0} ", arany+ezust+bronz);
            Console.WriteLine();
            Console.WriteLine("5. feladat:");

            int[] pont = new int[] {0, 7, 5, 4, 3, 2, 1};
            int osszpont = 0;
            foreach (var item in pontszerzok)
                osszpont += pont[item.helyezes];

            Console.WriteLine("Olimpiai pontok száma: {0}", osszpont);
            Console.WriteLine();
            Console.WriteLine("6. feladat:");
            int uszas = 0;
            int torna = 0;
            foreach (var item in pontszerzok)
            {
                if (item.sportag == "uszas") uszas++;
                if (item.sportag == "torna") torna++;

            }
            if (uszas > torna) Console.WriteLine("Úszás sportágban szereztek több érmet.");
            else if (uszas < torna) Console.WriteLine("Torna sportágban szereztek több érmet.");
            else Console.WriteLine("Egyenlő volt az érmek száma.");

            Console.WriteLine("7. feladat:");

            StreamWriter sw = new StreamWriter("helsinki2.txt");
            foreach (var item in pontszerzok)
            {
                if (item.sportag=="kajakkenu")
                {
                    sw.WriteLine("{0} {1} {2} kajak-kenu {3}", item.helyezes, item.fo, pont[item.helyezes], item.versenyszam);
                }
                else
                {
                    sw.WriteLine("{0} {1} {2} {3} {4}", item.helyezes, item.fo, pont[item.helyezes], item.sportag, item.versenyszam);
                }
            }
            sw.Close();

            Console.WriteLine("8. feladat:");
            
            int max = 0;
            int maxIndex = 0;

            for (int i = 0; i < pontszerzok.Count(); i++)
            {
                if (pontszerzok[i].fo > max)
                {
                    max = pontszerzok[i].fo;
                    maxIndex = i;
                }
            }
            Console.WriteLine("Helyezés: {0}", pontszerzok[maxIndex].helyezes);
            Console.WriteLine("Sportág: {0}", pontszerzok[maxIndex].sportag);
            Console.WriteLine("Versenyszám: {0}", pontszerzok[maxIndex].versenyszam);
            Console.WriteLine("Sportolók száma: {0}", pontszerzok[maxIndex].fo);
            Console.ReadKey();

        }
    }
}
