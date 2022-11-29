using CaesarCode;
using System;

namespace CaesarCodeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do szyfrowania");
            string text = Console.ReadLine();

            int shift=0;
            Console.WriteLine("Podaj przesunięcie");
            int.TryParse(Console.ReadLine(), out shift);

            string encryptText = new CaesarCodeClass().Encrypt(text, shift);
            Console.WriteLine("Zaszyfrowany tekst:");
            Console.WriteLine(encryptText);


            string decrypText = new CaesarCodeClass().Decrypt(encryptText, -shift);
            Console.WriteLine("Odszyfrowany tekst");
            Console.WriteLine(decrypText);
        }
    }
}
