using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletony
{
    class MonitorSingleton
    {
        private static MonitorSingleton instancja = null;

        public static MonitorSingleton ZwrocObiektSingletonu()
        {
            if (instancja == null)
                instancja = new MonitorSingleton();

            return instancja;
        }

        public string NazwaMonitora { get; set; }

        private MonitorSingleton()
        {
            
        }

        public void WyswietlNazwe()
        {
            Console.WriteLine(NazwaMonitora);
        }

    }
}
