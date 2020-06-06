using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            char day = (char)Console.Read();
            Console.ReadLine();
            switch (day)
            {
                case '1': Console.WriteLine("Понедiлок"); break;
                case '2': Console.WriteLine("Вiвторок"); break;
                case '3': Console.WriteLine("Середа"); break;
                case '4': Console.WriteLine("Четвер"); break;
                case '5': Console.WriteLine("П'ятниця"); break;
                case '6': Console.WriteLine("Субота"); break;
                case '7': Console.WriteLine("Недiля"); break;
            }
            Console.Read();
        }
    }
}
