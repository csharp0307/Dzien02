using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Klasy
{
    class Prostokat
    {
        // pola w klasie
        double bokA, bokB;

        public int test;

        // konstruktor
        public Prostokat(double bokA, double bokB )
        {
            this.bokA = bokA; this.bokB = bokB;
        }

        public Prostokat(double bok)
        {
            bokA = bok; bokB = bok;
        }

    }
}
