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

        public double ObliczPole()
        {
            return bokA * bokB;
        }

        public double ObliczObwod()
        {
            return 2 * bokA + 2 * bokB;
        }

        public bool czyKwadrat()
        {
            return bokA == bokB;
        }

        public String Print()
        {
            return String.Format("bokA={0} bokB={1}", bokA, bokB);
        }

        public override string ToString()
        {
            return Print();
        }

    }
}
