using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat:");
            int[] dobásokvmi = { 3, 1, 1, 2, 1, 5, 5, 4, 4, 4, 1, 2, 3, 6, 4, 6, 1, 4 };
            int[] dobások = new int[dobásokvmi.Length];
            Random estevan = new Random();
            for (int i = 0; i < dobások.Length; i++)
            {
                dobások[i] = estevan.Next(1, 7);
            }
            List<int> dobasoklista = new List<int>()
            { 3, 1, 1, 2, 1, 5, 5, 4, 4, 4, 1, 2, 3, 6, 4, 6, 1, 4 };
            /*for (int i = 0; i < adatok.Length; i++)
            {
                dobasoklista.Add(adatok[i]);
            }*/
            foreach (var item in dobasoklista)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("2. feladat:");
            int hely = 0;
            int visszalepes = 0;
            for (int i = 0; i < dobások.Length; i++)
            {
                hely = hely + dobások[i];
                if (hely%10==0)
                {
                    hely -= 3;
                    visszalepes++;
                }
                Console.Write("{0} ", hely);
            }
            Console.WriteLine();
            Console.WriteLine("3. feladat:");
            Console.WriteLine("A játék során {0} alkalommal lépett létrára.", visszalepes);

            Console.WriteLine("4. feladat");
            if (hely>=45)
            {
                Console.WriteLine("A játékot befejezte.");
            }
            else
            {
                Console.WriteLine("A játékot abbahagyta.");
            }
            Console.ReadKey();
        }
    }
}
