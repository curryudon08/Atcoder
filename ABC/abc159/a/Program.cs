using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var cn = n * (n - 1) / 2;
            var cm = m * (m - 1) / 2;
            Console.WriteLine(cn + cm);
        }
    }
}
