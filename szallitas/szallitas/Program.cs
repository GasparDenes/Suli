using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallitas
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targyak = {16, 8, 9, 4, 3, 2, 4, 7, 7, 12, 3, 5, 4, 3, 2};
            List<int> targyakk = new List<int>();

            //lista feltoltese:
            for (int i = 0; i < targyak.Length; i++)
            {
                targyakk.Add(targyak[i]);
            }

            Console.WriteLine("2. feladat:");
            int ossztomb = 0;
            for (int i = 0; i < targyak.Length; i++)
            {
                ossztomb += targyak[i];
            }
            Console.WriteLine("A tárgyak össztömege tömbbel:{0}", ossztomb);

            int osszlist = 0;
            foreach (var item in targyakk)
            {
                osszlist += item;
            }
            Console.WriteLine("A tárgyak össztömege listával:{0}", osszlist);

            Console.WriteLine("3. feladat:");
            Console.WriteLine("A dobozokok tartalmának tömege kg-ban:");
            int doboz = 0;
            int dobozokszama = 0;
            for (int i = 0; i < targyak.Length-1; i++)
            {
                doboz += targyak[i];
                if (doboz+targyak[i+1]>20)
                {
                    Console.Write(" {0}", doboz);
                    dobozokszama++;
                    doboz = 0;
                }
                
            }
            Console.WriteLine(" {0}", doboz+targyak[targyak.Length-1]);
            Console.WriteLine("Szükséges dobozok száma:{0}", dobozokszama+1);

            Console.ReadKey();
        }
    }
}
