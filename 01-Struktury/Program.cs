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
            //ListOper();
            //HashtableOper();
            //SortedListOper();
            //StackOper();
            QueueOper();
            Console.ReadKey();
            
        }

        private static void QueueOper()
        {
            Queue kolejka = new Queue();
            kolejka.Enqueue("A");
            kolejka.Enqueue("B");
            kolejka.Enqueue("C");
            kolejka.Enqueue("D");
            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }

            string s = "";
            while (kolejka.Count > 0)
            {
                s = (string)kolejka.Dequeue();
                Console.WriteLine(s);
            }





        }

        private static void StackOper()
        {
            // praca ze stosem
            Stack stos = new Stack();
            String s = "ABCDEF";
            foreach (var litera in s)
                stos.Push(litera);

            //wyswietlenie stosu
            foreach (var item in stos)
                Console.WriteLine(item);

            // zdjecie ze stosu
            char znak = (char)stos.Pop();
            Console.WriteLine("zdjęto={0}",znak);

            znak = (char)stos.Pop();
            Console.WriteLine("zdjęto={0}", znak);

            znak = (char)stos.Peek();
            Console.WriteLine("na szczycie={0}", znak);

            stos.Clear(); //czysci stos



        }

        private static void SortedListOper()
        {
            SortedList listaAut = new SortedList();
            listaAut.Add("001", "Audi");
            listaAut.Add("002", "Fiat");
            listaAut.Add("003", "Opel");
            listaAut.Add("004", "BMW");
            foreach (var k in listaAut.Keys)
            {
                Console.WriteLine("{0} = {1}", k, listaAut[k]);
            }
        }

        private static void HashtableOper()
        {
            Hashtable tabKrajow = new Hashtable();
            tabKrajow.Add("PL", "Polska");
            tabKrajow.Add("UK", "Wlk Brytania");
            tabKrajow.Add("DE", "Niemcy");
            tabKrajow.Add("CH", "Szwajcaria");
            tabKrajow.Add("SE", "Szwecja");

            String klucz = "DE";
            if (tabKrajow.ContainsKey(klucz))
            {
                Console.WriteLine(tabKrajow[klucz]);
            } else
            {
                Console.WriteLine("{0} nie istnieje", klucz);
            }

            Console.WriteLine(tabKrajow.ContainsValue("Niemcy"));

            tabKrajow.Remove("CH"); // usuwanie

            foreach (var k in tabKrajow.Keys)
            {
                Console.WriteLine("{0} = {1}", k, tabKrajow[k]);
            }


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

            // deklaracja listy z zadeklarowanym typem danych
            List<String> listaKrajow = new List<string>(10);
            listaKrajow.Add("Polska");
            listaKrajow.Add("Andora");
            listaKrajow.Add("Niemcy");
            listaKrajow.Add("Austria");
            string s = String.Format("Liczba elementów={0}, pojemnosc={1}", 
                                        listaKrajow.Count, listaKrajow.Capacity );
            //           0                    1
            Console.WriteLine(s);
            listaKrajow.Add("Belgia");
            listaKrajow.Add("Hiszpania");
            listaKrajow.Add("Rumunia");
            listaKrajow.Add("Włochy");
            listaKrajow.Add("Portugalia");
            listaKrajow.Add("Szwecja");
            listaKrajow.Add("Łotwa");
            listaKrajow.Add("Dania");
            Console.WriteLine("Liczba elementów={0}, pojemnosc={1}",
                                        listaKrajow.Count, listaKrajow.Capacity);


            listaKrajow[0] = "POLSKA";
            listaKrajow.Sort();
            foreach (var item in listaKrajow)
            {
                Console.WriteLine(item);
            }

            listaKrajow.RemoveRange(7, 3);
            Console.WriteLine("Liczba elementów={0}, pojemnosc={1}",
                                        listaKrajow.Count, listaKrajow.Capacity);
            listaKrajow.TrimExcess(); //usuwamy nadmiarowość w zajmowanej pamięci
            Console.WriteLine("Liczba elementów={0}, pojemnosc={1}",
                                        listaKrajow.Count, listaKrajow.Capacity);


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
