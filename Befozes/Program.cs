using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Befozes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> uvegek = new List<int>(){ 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };
            Console.WriteLine("2. Feladat");

            Console.Write("Mari néni lekvárja (dl): ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("3. Feladat");
            int max = uvegek.Max();
            int index = uvegek.IndexOf(max);

            /*for (int i = 0; i < uvegek.Count(); i++)
            {
                if (uvegek[i] > maxi)
                {
                    max = uvegek[i];
                    index = i;
                }
            }*/
            Console.WriteLine("A legnagyobb üveg : {0} dl és {1}. a sorban", max, index + 1);
            Console.WriteLine();
            Console.WriteLine("4. Feladat");

            int osszeg = 0;
            foreach (var item in uvegek)
            {
                osszeg += item;
            }

            if (osszeg >= l)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Elegendő üveg volt");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Maradt lekvár");
            }
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
