using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szolanc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mehet_meg = true;
            int n = 0;
            //String[] szavak = new string[100];
            List<String> szavak = new List<String>();
            char utolso;
            char elso;

            while (mehet_meg)
            {
                Console.Write("Kérem a(z) {0}. szót: ", n+1);
                szavak.Add(Console.ReadLine());
                if (szavak[n].Length!=6)
                {
                    mehet_meg = false;
                    Console.WriteLine("A karakterek száma téves!");
                }

                else
                {
                    if (n!=0)
                    {
                        elso = szavak[n][0];
                        utolso = szavak[n - 1][5];
                        if (elso!=utolso)
                        {
                            mehet_meg = false;
                            Console.WriteLine("Nem Illeszkedett!");
                        }
                    }
                }
                n++;
            }

            Console.WriteLine("A helyes szavak száma:{0}", n);

            /*if (n<=2)
            {
                Console.WriteLine("Kezdő");
            }
            else if (n<=5)
            {
                Console.WriteLine("Közepes");
            }
            else
            {
                Console.WriteLine("Haladó");
            }
            */
            switch (n)
            {
                case 0: Console.WriteLine("Kezdő");
                    break;
                case 1:
                    Console.WriteLine("Kezdő");
                    break;
                case 2:
                    Console.WriteLine("Kezdő");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Közepes");
                    break;
                case 5:
                    Console.WriteLine("Közepes");
                    break;
                default: Console.WriteLine("Haladó");
                    break;

            }
            foreach (var item in szavak)
            {
                Console.Write("{0}, ", item);
            }
            Console.ReadKey();
        }
    }
}
