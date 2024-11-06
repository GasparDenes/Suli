using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömbök
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[20];
            Random szamok = new Random();
            
            for (int i = 0; i < lotto.Length; i++)
            {
                //lotto[i] = (i + 1) * 3;      3-mal osztható számokkal töltjük fel.
                lotto[i] = szamok.Next(100, 201);
            }

            for (int i = 0; i < lotto.Length; i++)
            {
                if (i==(lotto.Length-1))
                {
                    Console.WriteLine("{0}", lotto[i]);
                }
                else
                    Console.Write("{0}, ", lotto[i]);
            }
            int osszeg = 0;
            for (int i = 0; i < lotto.Length; i++)
            {
                osszeg += lotto[i];
            }
            Console.WriteLine("A lottószámok összege:{0}", osszeg);
            Console.ReadKey();
        }
    }
}
