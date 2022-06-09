using System;

namespace Inf04_Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortowaniePrzezWybieranie sortowaniePrzezWybieranie = new SortowaniePrzezWybieranie();
            sortowaniePrzezWybieranie.WczytajLiczby();
            sortowaniePrzezWybieranie.SortujRosnaco();
            sortowaniePrzezWybieranie.WyswietlLiczby();
        }
    }
}
