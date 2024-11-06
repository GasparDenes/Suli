using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szakkör_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double r = 10;
            //Circle c = new Circle(r);
            //c.printA();
            //c.printP();

            Customer c = new Customer(10, "PAUL", "LONDON") ;
            //Customer[] tomb = new Customer[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    tomb[i] = new Customer(1, "PETER", "SZEGED");
            //}

            List<Customer> list = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Customer(1, "PETER,", "SZEGED"));
            }
            int a = 0;
            int b = 5;

            a = a + 1;
            a += 1;
            a = ++b; //6 ->először hozzáad, utána tárol
            a = b++; //5 ->először tárol, utána hozzáad

            Console.ReadKey();
        }
    }
}
