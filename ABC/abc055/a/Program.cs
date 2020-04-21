using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var x = 800 * n;
            var y = (n / 15) * 200;

            Console.WriteLine(x - y);
        }
    }
}
