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
            public string vnev, knev, korzet, part;
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
            Console.ReadKey();
        }
    }
}
