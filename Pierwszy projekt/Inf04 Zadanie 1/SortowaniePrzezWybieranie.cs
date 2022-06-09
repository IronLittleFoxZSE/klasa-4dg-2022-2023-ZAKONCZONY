using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf04_Zadanie_1
{
    class SortowaniePrzezWybieranie
    {
        private int[] tablicaLiczb = new int[10];

        public void WczytajLiczby()
        {
            Console.WriteLine("Podaj liczby:");
            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                Console.Write(i + ":");
                tablicaLiczb[i] = int.Parse(Console.ReadLine());
            }
        }

        public void WyswietlLiczby()
        {
            Console.WriteLine("Podane liczby:");
            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                Console.Write(tablicaLiczb[i] + ", ");
            }
        }

        /********************************************************
        * nazwa funkcji: SortujRosnaco
        * parametry wejściowe: brak
        * wartość zwracana: brak
        * autor: <numer PESEL zdającego>
        * ****************************************************/
        public void SortujRosnaco()
        {
            for (int i = 0; i < tablicaLiczb.Length - 1; i++)
            {
                int indexMax = SzukajIndeksMax(i);

                int tmp = tablicaLiczb[i];
                tablicaLiczb[i] = tablicaLiczb[indexMax];
                tablicaLiczb[indexMax] = tmp;
            }
        }

        /********************************************************
        * nazwa funkcji: SzukajIndeksMax
        * parametry wejściowe: indexStart - indeks od którego będzie poszukiwana wartość maksymalna
        * wartość zwracana: indeks znalezionej wartości maksymalnej
        * autor: <numer PESEL zdającego>
        * ****************************************************/
        private int SzukajIndeksMax(int indexStart)
        {
            int indexMax = indexStart;
            for (int i = indexStart; i < tablicaLiczb.Length; i++)
            {
                if (tablicaLiczb[indexMax] < tablicaLiczb[i])
                    indexMax = i;
            }
            return indexMax;
        }
    }
}
