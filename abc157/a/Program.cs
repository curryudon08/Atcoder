using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? n / 2 : n / 2 + 1);
        }
    }
}
