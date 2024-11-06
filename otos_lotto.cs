using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generáljunk 100 db véletlen számot, egymás alá írjuk ki!
            Random veletlenszam = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int x = veletlenszam.Next(1, 91);
                    if (x<10)
                    {
                        Console.Write(" {0}, ", x);
                    }
                    else
                    {
                        Console.Write("{0}, ", x);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
