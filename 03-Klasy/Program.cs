using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat1 = new Prostokat(3, 4);
            prostokat1.test = 10;
            Prostokat prostokat2 = new Prostokat(6);

            List<Prostokat> prostokaty = new List<Prostokat>();
            for (int i = 1; i <= 10; i++)
            {
                prostokaty.Add( new Prostokat(i+1, i+2)  );
            }

            foreach (var p in prostokaty)
            {
                if (p.ObliczObwod()>40)
                {
                    Console.WriteLine(p);
                }
            }

            Console.ReadKey();

        }
    }
}
