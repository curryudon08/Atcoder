using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = long.Parse(Console.ReadLine());

            Console.WriteLine(s < 1200 ? "ABC" : "ARC");
        }
    }
}
