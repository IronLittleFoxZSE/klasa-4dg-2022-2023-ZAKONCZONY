using System;

namespace Singletony
{
    class Program
    {
        static void Main(string[] args)
        {
            MonitorSingleton m1;// = new MonitorSingleton();
            m1 = MonitorSingleton.ZwrocObiektSingletonu();

            m1.NazwaMonitora = "AOC";

            MonitorSingleton m2 = MonitorSingleton.ZwrocObiektSingletonu();
            m2.WyswietlNazwe();
        }
    }
}
