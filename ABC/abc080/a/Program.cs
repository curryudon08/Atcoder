using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var a = int.Parse(_[1]);
            var b = int.Parse(_[2]);

            var p = Math.Min(n * a, b);
            Console.WriteLine(p);
        }
    }
}
