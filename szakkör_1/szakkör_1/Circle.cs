using System;

namespace szakkör_1
{
    internal class Circle
    {
        //adattag
        private double r;
        private double PI = 3.14;

        //tagfüggvény, metódus
        public Circle(double r)
        {
            this.r = r;
        }

        internal void printA()
        {
            //kör területe:r*r*pi
            double t = 0;
            t = r * r * PI;
            Console.WriteLine(t);

        }

        internal void printP()
        {
            double k = 0;
            k = 2 * r * PI;
            Console.WriteLine(k);
        }
    }
}