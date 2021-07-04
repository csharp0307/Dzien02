using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Co jest wieksze: 5 czy 3? {0}", FindMax(5,3) );

            // zamiana wartosci zmiennych
            int x = 100, y = -100;
            int[] tab = new int[3];
            SwapVar(ref x, ref y, tab);
            Console.WriteLine("X={0}, Y={1}, tab={2}", x, y, tab);

            Console.ReadKey();
        }

        private static void SwapVar(ref int a, ref int b, int[] c)
        {
            int tmp = a;
            a = b;
            b = tmp;
            c[0] = 999;
        }

        static void DummyMethod()
        {

        }

        static int FindMax(int a, int b)
        {
            /*if (a > b)
                return a;
            else
                return b;*/
            return (a > b) ? a : b;
        }
    }
}
