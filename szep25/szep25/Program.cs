using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szep25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.:
            string körte = "alma";
            //2.:
            Console.WriteLine(körte[2]);
            //3.:
            Random sportfogadas = new Random();
            //4.:
            string[] duma = new string[20];
            //5.:
            for (int i = 0; i < duma.Length; i++)
            {
                //duma[i] = sportfogadas.Next(1, 101);
            }
            //6.:Típuseltérés miatt hibába ütközünk, hiszen a duma tömb csak string változókat tárolhat, mi pedig random számot(intet) generáltunk.
            */
            string[] nevek = { "Miki", "Nóri", "Béla", "Kati", "Feri", "Jani", "Soma", "Tomi", "Laci", "Miki", "Doma", "Geri" };
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            string[] masolat = new string[nevek.Length];

            int masolathoz = 0;
            for (int i = 0; i < masolat.Length; i++)
            {
                if (nevek[i][1]=='a')
                {
                    masolat[masolathoz]= nevek[i];
                    masolathoz++;
                }
            }
            for (int i = 0; i < masolathoz; i++)
            {
                Console.Write("{0,5}", masolat[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < nevek.Length; i++)
            {
                int db = 0;
                for (int j = 0; j < nevek[i].Length; j++)
                {
                    if (nevek[i][j]=='i')
                    {
                        db++;
                    }
                }
                if (db==2)
                {
                    Console.Write("{0,5}", nevek[i]);
                }
                db = 0;
            }
            Console.ReadKey();
        }
    }

}
