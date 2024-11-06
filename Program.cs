using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Első feladat:");
            Console.WriteLine("Az A csoportot írom.");

            Console.WriteLine("Második feladat:");
            int[] tomb = new int[10];
            Random vszam = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vszam.Next(0, 91);
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Harmadik feladat:");
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]<30)
                {
                    osszeg += tomb[i];
                }
            }
            Console.WriteLine("A 30-nál kisebb tömbelemek összege: {0}", osszeg);

            Console.WriteLine("Negyedik feladat:");
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]==25)
                {

                    Console.WriteLine("A 25 értékű elem sorszáma: {0}", i+1);
                }
                else
                {
                    szamlalo++;
                }
            }
            if (szamlalo==tomb.Length)
            {
                Console.WriteLine("Hiba: a tömben nincsen 25 értékű elem!");
            }

            Console.WriteLine("Ötödik feladat:");
            int otven = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]<50)
                {
                    otven++;
                }
            }
            if (otven!=0)
            {
                Console.WriteLine("Az 50-nél kisebb elemek száma:{0}", otven);
            }
            else
            {
                Console.WriteLine("Hibaüzenet: nincsen a tömbben 50-nél kisebb elem!");
            }
            Console.WriteLine("Hatodik feladat:");
            bool talalt_szamot = false;
            int j = 0;
            while (talalt_szamot==false)
            {
                if (tomb[j]>20 && tomb[j]<30)
                {
                    talalt_szamot = true;
                    Console.WriteLine("A megtalált 20 és 30 közötti elem:{0}", tomb[j]);
                }
                else if (j==tomb.Length-1)
                {
                    talalt_szamot = true;
                    Console.WriteLine("Hibaüzenet:nincsen 20 és 30 közötti elem a tömbben!");
                }
                j++;
            }

            Console.WriteLine("Hetedik feladat:");
            int[] tomb2 = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb2[i] = tomb[i] * 10;
            }
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write("{0}, ", tomb2[i]);
            }
            Console.ReadKey();
        }
    }
}
