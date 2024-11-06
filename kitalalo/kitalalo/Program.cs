using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] szavak = {"bab", "mag", "aba", "sir", "sin" };
            Random feladat = new Random();

            int rejtett = feladat.Next(0, 5);
            bool mehet_még = true;
            int pontok = 3;
            char[] valasz = { '.', '.', '.' };

            while (mehet_még)
            {
                //Console.WriteLine("A rejtett szó:\t{0}", szavak[rejtett]);

                Console.Write("Add meg a tippedet: ");
                string tipp = Console.ReadLine();
                if (tipp=="stop")
                {
                    mehet_még = false;
                }

                else
                {
                    Console.WriteLine("A rejtett szó:\t{0}", szavak[rejtett]);
                    Console.WriteLine("A tipp:\t\t{0}", tipp);

                    //Pontok kicserélése:
                    for (int i = 0; i < tipp.Length; i++)
                    {
                        if (tipp[i] == szavak[rejtett][i])
                        {
                            valasz[i] = tipp[i];
                            pontok--;
                        }

                    }

                    //string seged="";
                    //Válasz kiírása:
                    Console.Write("Válasz:\t\t");
                    for (int i = 0; i < valasz.Length; i++)
                    {
                        Console.Write(valasz[i]);
                        //seged = seged + valasz[i].ToString();
                    }

                    if (pontok == 0)
                    {
                        mehet_még = false;
                    }

                    Console.WriteLine();
                    //Console.WriteLine(seged);
                }

            }
            Console.ReadKey();
        }
    }
}
