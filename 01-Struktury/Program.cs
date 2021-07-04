using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayOper();
            ListOper();
            Console.ReadKey();
        }

        // operacje na listach
        private static void ListOper()
        {
            ArrayList listaImion = new ArrayList();
            listaImion.Add("Adam");
            listaImion.Add(10);
            listaImion.Add(false);
            listaImion.Add(-123.45);
            listaImion.Add(new int[5]);
            listaImion.Insert(1, true);
            listaImion.RemoveAt(0);
            listaImion.Remove(10);
            Console.WriteLine("Liczba el="+listaImion.Count+", pojemnosc="+listaImion.Capacity);
        }

        // operacje na tablicach
        private static void ArrayOper()
        {
            // inicjalizacja tablicy
            int[] stawkiVAT = new int[10]; // deklaracja 10-elementowej tablicy liczb typu int
            stawkiVAT[0] = 8;
            stawkiVAT[9] = 23;
            //stawkiVAT[999] = 0;

            int[] oceny1 = new int[6] { 1, 2, 3, 4, 5, 6 }; // przypisanie wartości w momencie inicjalizacji
            int[] oceny2 = new int[] { 1, 2, 3, 4, 5, 6 }; // przypisanie wartości w momencie inicjalizacji
            Console.WriteLine("Liczba elementów:"+ oceny2.Length );
            for (int i = 0; i < oceny2.Length; i++)
            {
                Console.Write(oceny2[i]+",");
            }
            Console.WriteLine();
            foreach (var item in oceny2)
            {
                Console.Write( item+",");
            }
            Console.WriteLine();

            // klonowanie tablic
            int[] oceny3 = (int[])oceny1.Clone();
            oceny3[0] = 99;
            foreach (var item in oceny1)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            foreach (var item in oceny3)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            // kopiowanie tablic
            int[] oceny2a = new int[30];
            Array.Copy(oceny2, 0, oceny2a, 9, oceny2.Length);
            foreach (var item in oceny2a)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            // deklaracja tablicy N-wymiarowej
            int[,] macierz1 = new int[3, 4]; //3 wiersze i 4 kolumny
            int[,] macierz2 = new int[3, 4] 
            {
                {1,2,3,4},
                {5,6,7,8 },
                {9, 10, 11, 12 }
            }; //3 wiersze i 4 kolumny

            // iteracja po macierzy
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(macierz2[i,j]*2 + ", ");
                }
                Console.WriteLine();
            }



        }
    }
}
