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
            int result;
            FindMaxOut(5, 3, out result);
            Console.WriteLine("Co jest wieksze: 5 czy 3? {0}", result);

            // zamiana wartosci zmiennych
            int x = 100, y = -100;
            int[] tab = new int[3];
            SwapVar(ref x, ref y, tab);
            Console.WriteLine("X={0}, Y={1}, tab={2}", x, y, tab);

            // przykład wywołania metody z param. opcjonalnymi
            PrintData("Jan", "Kowalski", 44, 5678);
            PrintData("Jan", "Kowalski");
            PrintData("Jan", "Kowalski", 33);
            PrintData("Jan", "Kowalski", salary:5678);
            PrintData("Jan", "Kowalski", salary:5678, age:22);

            Console.ReadKey();
        }

        private static void TestMethod(int a)
        {

        }

        private static void TestMethod(long a)
        {

        }

        private static void TestMethod(int a, int b)
        {

        }

        private static void TestMethod(string a, int b)
        {

        }

        private static void PrintData(string fname, string lname, int age=0, double salary=0.0)
        {
            Console.WriteLine("{0} {1}, wiek={2}, zarobki={3}", fname, lname, age, salary);
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

        static void FindMaxOut(int a, int b, out int c)
        {
            /*if (a > b)
                return a;
            else
                return b;*/
            c = (a > b) ? a : b;
        }
    }
}
