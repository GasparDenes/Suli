using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszefoglalas
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.: Tipp-mix néven hozzon létre egy vszám generátort!
            //2.: Alma néven hozzon létre egy szöveg típusú változót és a változó tartalma körte legyen!
            //3.: Betűk néven hozzon létre egy tömböt, ami 10 elemű, és karaktereket tartalmazhat!
            //4.: Az előbb létrehozott tömb 3. eleme az előbb létrehozott vszám generátor segítségével 10 és 100 közötti szám legyen!
            //5.: Kommentben magyarázd meg, hogy az előző feladatban fellép-e típuseltérési hiba.
            //6.: Készítsen egy üres számláló ciklust, aminek ciklusváltozója k és 1-től 15-ig számol.

            Random tipp_mix = new Random();
            String alma = "körte";
            int[] betűk = new int[10];
            betűk[2] = tipp_mix.Next(1, 101);
            //fellép, hiszen a lista csak karaktereket tartalmazhat.

            for (int k = 1; k < 16; k++)
            {
                Console.WriteLine(k);
            }
            

            int[] adatok = {10, 3, 11, 1, 25, 32, 14, 9, 88, 7};

            //elemek összeadása:
            int osszeg = 0;
            for (int i = 0; i < adatok.Length; i++)
            {

                Console.Write("{0,3}", adatok[i]);    //vessző utáni hármas azt jelöli, hogy egy érték szóközzel együtt mennyi karakter heleyet foglaljon.
            }
            for (int a = 0; a < adatok.Length; a++)
            {
                osszeg += adatok[a];
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A tömb elemeinek összege:{0}",osszeg);

            //Minimum kiválasztás:
            int minimum = adatok[0];
            for (int m = 0; m < adatok.Length; m++)
            {
                if (adatok[m]<minimum)
                {
                    minimum = adatok[m];
                }

            }
            Console.WriteLine();
            Console.WriteLine("A legisebb elem: {0}", minimum);

            //Maximum kiválasztás:
            int maximum = adatok[0];
            for (int m = 0; m < adatok.Length; m++)
            {
                if (adatok[m] > maximum)
                {
                    maximum = adatok[m];
                }

            }
            Console.WriteLine();
            Console.WriteLine("A legnagyobb elem: {0}", maximum);

            //páros számok:
            Console.Write("A páros számok:");
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] % 2 == 0)
                {
                    Console.Write("{0, 3}", adatok[i]);
                }

            }
            Console.WriteLine();

            //növekvő sorrend:
            Array.Sort(adatok);
            for (int i = 0; i < adatok.Length; i++)
            {
                Console.Write("{0,3}", adatok[i]);
            }

            //stringek sorbarendezése:
            Console.WriteLine();
            string[] jatek = { "dom", "sár", "aba", "sar", "kat" };
            Array.Sort(jatek);

            for (int i = 0; i < jatek.Length; i++)
            {
                Console.Write("{0,4}", jatek[i]);
            }

            Console.WriteLine();

            Console.Write("A 2. karaktere 'a':");
            for (int i = 0; i < jatek.Length; i++)
            {
                if (jatek[i][1] == 'a')
                {
                    Console.Write("{0,4}", jatek[i]);
                }
            }
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
