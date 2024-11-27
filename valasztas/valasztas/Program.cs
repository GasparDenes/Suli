using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //FONTOS A FÁJLBEOLVASÁSHOZ!

namespace valasztas
{
    class Program
    {
        struct Egykepviselo //típus, amit az osztályban hozunk létre
        {
            public string vnev, knev, korzet, part;     //a körzet az szám, viszont stringben érdemes tárolni!
            public int szavazatok;
        }
        static void Main(string[] args)
        {
            List<Egykepviselo> kepviselo = new List<Egykepviselo>();

            StreamReader olvaso = new StreamReader("szavazatok.txt");
            
            while (!olvaso.EndOfStream)
            {
                string[] egysor = olvaso.ReadLine().Split(' '); //separatornál eltörjük a sort
                Egykepviselo seged = new Egykepviselo();
                seged.korzet = egysor[0];
                seged.szavazatok = int.Parse(egysor[1]);
                seged.vnev = egysor[2];
                seged.knev = egysor[3];
                seged.part = egysor[4];
                kepviselo.Add(seged);
            }

            olvaso.Close(); //ezután már nem hivatkozhatunk az olvasóra!
            foreach (var item in kepviselo)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", item.korzet, item.szavazatok, item.vnev, item.knev, item.part);

                /*VAGY
                
                string kiiras = String.Join("\t", item.korzet, item.szavazatok, item.vnev, item.knev, item.part);
                Console.WriteLine(kiiras);*/
            }
            Console.WriteLine("2. feladat: ");
            Console.WriteLine("A helyhatósági választáson {0} képviselőjelölt indult.", kepviselo.Count());

            Console.WriteLine("3. feladat: ");
            Console.WriteLine("Add meg a vezetéknevét: ");
            string vezetek = Console.ReadLine();

            Console.WriteLine("Add meg a keresztnevét: ");
            string kereszt = Console.ReadLine();

            int szavazat = 0;
            bool talaltam = false;

            foreach (var item in kepviselo)
            {
                if (item.vnev == vezetek && item.knev == kereszt)
                {
                    szavazat = item.szavazatok;
                    talaltam = true;
                }
                else 
                {
                    
                }
            }

            if (talaltam)
                Console.WriteLine("Az illető {0} szavazatot kapott.", szavazat);
            else
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");

            Console.WriteLine("4. feladat:");
            const int osszszavazo = 12345;
            int leadottszavazat = 0;
            
            foreach (var item in kepviselo)
            {
                leadottszavazat += item.szavazatok;
            }

            float szazalek = (float) leadottszavazat / osszszavazo * 100;  //az intet floattá kell váltani!
            Console.WriteLine(szazalek);
            Console.WriteLine("A választáson {0} állampolgár, a jogosultak {1} %-a vett részt. ", leadottszavazat, Math.Round(szazalek, 2));

            Console.WriteLine("5. feladat:");
            int gyep = 0;
            int hep = 0;
            int tisz = 0;
            int zep = 0;
            int fugg = 0;
            foreach (var item in kepviselo)
            {
                if (item.part == "GYEP")
                    gyep += item.szavazatok;
                if (item.part == "HEP")
                    hep += item.szavazatok;
                if (item.part == "TISZ")
                    tisz += item.szavazatok;
                if (item.part == "ZEP")
                    zep += item.szavazatok;
                if (item.part == "-")
                    fugg += item.szavazatok;
            }
            Console.WriteLine("Gyümölcsevők Pártja= {0}%", Math.Round((float) gyep/leadottszavazat * 100, 2));
            Console.WriteLine("Húsevők Pártja= {0}%", Math.Round((float)hep / leadottszavazat * 100, 2));
            Console.WriteLine("Tejivók Szövetsége= {0}%", Math.Round((float)tisz / leadottszavazat * 100, 2));
            Console.WriteLine("Zöldségevők Pártja= {0}%", Math.Round((float)zep / leadottszavazat * 100, 2));
            Console.WriteLine("Függetlenek jelöltek= {0}%", Math.Round((float)fugg / leadottszavazat * 100, 2));

            int max = 0;
            foreach (var item in kepviselo)
            {
                if (item.szavazatok>max)
                {
                    max = item.szavazatok;
                }
            }
            foreach (var item in kepviselo)
            {
                if (max==item.szavazatok)
                {
                    Console.WriteLine("{0} {1} {2}", item.vnev, item.knev, item.part);
                }
            }
            Console.ReadKey();
        }
    }
}
