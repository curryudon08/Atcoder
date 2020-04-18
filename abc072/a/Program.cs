using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = long.Parse(_[0]);
            var t = long.Parse(_[1]);

            Console.WriteLine(Math.Max(x - t, 0));
        }
    }
}
