using System;

namespace ProgramPesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer Pesel");
            string numerPesel = Console.ReadLine();
            try
            {
                Pesel pesel = new Pesel(numerPesel);
                Console.WriteLine("Plec osoby: " + pesel.Plec);
                Console.WriteLine("Plec osoby: " + pesel.PlecOpis);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
