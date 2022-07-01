using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soft
{
    class Prostokat
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Szer: {0}, Dł: {1}, Ob: {2}, Pow: {3}",
                this.szerokosc, this.dlugosc, this.LiczObwod(), this.LiczPowierzchnie());
        }

        private double LiczObwod()
        {
            return 2.0 * (this.szerokosc + this.dlugosc);
        }

        private double LiczPowierzchnie()
        {
            return this.szerokosc * this.dlugosc;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pr = new Prostokat(2.5, 5.6);
            pr.Prezentuj();
        }
    }
}