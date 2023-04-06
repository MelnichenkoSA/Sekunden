using System;

namespace Sekunden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите секунды");
            int x = int.Parse(Console.ReadLine());
            Zeit zeit = new Zeit(x);
            zeit.Drucken();
        }
    }
}
