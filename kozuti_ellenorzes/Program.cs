using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kozuti_ellenorzes
{
    class Program
    {
        struct ellenorzes
        {
            public int ora, perc, mp;
            public string rendszam;
        }
        static void Main(string[] args)
        {
            List<ellenorzes> adatok= new List<ellenorzes>();
            StreamReader olvaso = new StreamReader("jarmu.txt");
        }
    }
}
