using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Üdv neked!");
            Console.Write("Hány éves vagy?");

            string szam = Console.ReadLine();
            int eletkor = int.Parse(szam);

            if (eletkor < 14)
            //ha csak egy sort írunk az if-be,akkor nem kell kapcsos zárójel!
                Console.WriteLine("Jé, hogyhogy már középsikolás vagy?");
            else
                Console.WriteLine("Egy év múlva már {0} éves leszel!", eletkor + 1);

            Console.Write("Mi volt Mátyás király keresztneve? ");
            string valasz = Console.ReadLine();
            if (valasz=="Mátyás")
            {
                Console.WriteLine("Valóban.");
            }
            else
            {
                Console.WriteLine("Hát, majdnem.");
            }

            string csillagok = new string('*', 10);
            Console.WriteLine(csillagok);
            */

            int[] tomb = new int[4]; //új tömb,ami 4 egész szám tárolására alkalmas.
            int[] tomb2 = { 2, 4, 6, 8 }; //új tömb, aminek elemeit egyből megadtuk.
            string szoveg = "vízalatti pacsirta csapda";
            Console.WriteLine(szoveg[5]); //a string emiatt sorszámozott típus!
            Console.WriteLine(tomb2[2]);
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine(tomb2[i]);
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
